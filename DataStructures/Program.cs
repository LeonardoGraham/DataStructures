// See https://aka.ms/new-console-template for more information

namespace DataStructures;

public class TrieNode
{
    private const int SizeOfAlphabet = 26;
    
    public bool IsWord { get; set; }
    public TrieNode[] Children = new TrieNode[SizeOfAlphabet];
}
public class Trie
{
    // private TrieNode? _head; 
    public void Add(string word)
    {
        // TODO
    }
}