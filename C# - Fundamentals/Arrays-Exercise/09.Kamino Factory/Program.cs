using System;
using System.Linq;

int sampleLength = int.Parse(Console.ReadLine());

int bestSequenceIndex = 0;
int bestSequenceLength = 0;
int bestSequenceSum = 0;
int bestSequenceStartIndex = 0;
int[] bestSequence = new int[sampleLength];
int sequenceCounter = 0;

string command = Console.ReadLine();
while (command != "Clone them!")
{
    sequenceCounter++;
    int currSeqLength = 1;
    int currBestSeqLength = 0;
    int currSeqStartIndex = 0;
    int currSeqSum = 0;
    int[] currSequence = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int i = 0; i < currSequence.Length - 1; i++)
    {
        if (currSequence[i] == currSequence[i + 1])
        {
            currSeqLength++;
        }
        else
        {
            currSeqLength = 1;
        }
        if(currSeqLength > currBestSeqLength)
        {
            currBestSeqLength = currSeqLength;
            currSeqStartIndex = i;
        }
        currSeqSum += currSequence[i];
    }
    currSeqSum += currSequence[^1];
    if(currBestSeqLength > bestSequenceLength)
    {
        bestSequenceLength = currBestSeqLength;
        bestSequenceStartIndex = currSeqStartIndex;
        bestSequenceSum = currSeqSum;
        bestSequenceIndex = sequenceCounter;
        bestSequence = currSequence.ToArray();
    }
    else if(currBestSeqLength == bestSequenceLength)
    {
        if(currSeqStartIndex < bestSequenceStartIndex)
        {
            bestSequenceLength = currBestSeqLength;
            bestSequenceStartIndex = currSeqStartIndex;
            bestSequenceSum = currSeqSum;
            bestSequenceIndex = sequenceCounter;
            bestSequence = currSequence.ToArray();
        }
        else if(currSeqStartIndex == bestSequenceStartIndex)
        {
            if(currSeqSum > bestSequenceSum)
            {
                bestSequenceLength = currBestSeqLength;
                bestSequenceStartIndex = currSeqStartIndex;
                bestSequenceSum = currSeqSum;
                bestSequenceIndex = sequenceCounter;
                bestSequence = currSequence.ToArray();
            }
        }
    }

    command = Console.ReadLine();
}
Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
Console.WriteLine($"{string.Join(" ", bestSequence)}"); 
