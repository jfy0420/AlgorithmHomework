using System;

namespace algorithmHomework{
/*
208. trie的实现
*/
    public class Trie{
        private TrieNode root;
        public Trie() {
            root=new TrieNode();
        }
        
        public void Insert(string word) {
            TrieNode node=root;
            foreach(var ch in word){
                if(!node.ContainsKey(ch)){
                    node.Set(ch,new TrieNode());
                }
                node=node.Get(ch);
            }
            node.SetEnd();
        }
        
        public bool Search(string word) {
            TrieNode node=SearchPrefix(word);
            return node!=null && node.IsEnd();
        }
        
        public bool StartsWith(string prefix) {
            TrieNode node=SearchPrefix(prefix);
            return node!=null;
        }

        private TrieNode SearchPrefix(string word){
            TrieNode node=root;
            foreach(var c in word)
            {
                if(node.ContainsKey(c)){
                    node=node.Get(c);
                }
                else{
                    return null;
                }
            }
            return node;
        }

    }

    public class TrieNode{
        private TrieNode[] links;
        private const int R=26;
        private bool isEnd;

        public TrieNode(){
            links=new TrieNode[R];
        }

        public TrieNode Get(char ch){
            return links[ch-'a'];
        }

        public void Set(char ch, TrieNode node){
            links[ch-'a']=node;
        }

        public bool IsEnd(){
            return isEnd;
        }

        public void SetEnd()
        {
            isEnd=true;
        }

        public bool ContainsKey(char ch){
            return links[ch-'a'] !=null;
        }
    }
}