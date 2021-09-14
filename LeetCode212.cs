using System.Collections.Generic;
using System;

namespace algorithmHomework{
/*
212. Word Search II
*/
    public class LeetCode212{
        ///TODO: not understand
        public IList<string> FindWords(char[][] board, string[] words) {
        var res = new List<string>();
        // construct the Trie
        var root = new TrieNode();
        foreach (var word in words) {
            var cur = root;
            foreach (var c in word) {
                if (cur.children.ContainsKey(c)) {
                    cur = cur.children[c];
                } else {
                    var newnode = new TrieNode();
                    cur.children[c] = newnode;
                    cur = newnode;
                }
            }
            cur.word = word;
        }
        
        int m = board.Length;
        int n = board[0].Length;
        for (int i=0; i<m; i++) {
            for (int j=0; j<n; j++) {
                if (root.children.ContainsKey(board[i][j])) {
                    DFS(board, i, j, root, res);
                }
            }
        }
        return res;
    }
    
    public void DFS(char[][] board, int i, int j, TrieNode cur, List<string> res) {
        if (cur.word != null) {
            res.Add(cur.word);
            cur.word = null; // once visited, set as null, otherwise, it would go here again in the trie
        }
        
        if (i < 0 || j < 0 || i >= board.Length || j >= board[0].Length || !cur.children.ContainsKey(board[i][j])) return;
        
        var tmp = board[i][j];
        board[i][j] = '0';
        
        DFS(board, i+1, j, cur.children[tmp], res);
        DFS(board, i-1, j, cur.children[tmp], res);
        DFS(board, i, j+1, cur.children[tmp], res);
        DFS(board, i, j-1, cur.children[tmp], res);
        
        board[i][j] = tmp;
    }
}

public class TrieNode {
    public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
    public string word = null;
    
    public TrieNode() {}
}
    
}