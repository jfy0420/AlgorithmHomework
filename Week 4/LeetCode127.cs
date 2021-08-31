using System;
using System.Collections.Generic;

namespace algorithmHomework{

/* 单词接龙
字典 wordList 中从单词 beginWord 和 endWord 的 转换序列 是一个按下述规格形成的序列：

序列中第一个单词是 beginWord 。
序列中最后一个单词是 endWord 。
每次转换只能改变一个字母。
转换过程中的中间单词必须是字典 wordList 中的单词。
给你两个单词 beginWord 和 endWord 和一个字典 wordList ，找到从 beginWord 到 endWord 的 最短转换序列 中的 单词数目 。如果不存在这样的转换序列，返回 0。
*/
    public class LeetCode127{
        // 用26个字母
        public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
            HashSet<string> wordSet=new HashSet<string>(wordList);

            if(wordList.Count==0||!wordSet.Contains(endWord)){
                return 0;
            }
            wordSet.Remove(beginWord);

            //广度搜索：使用队列和visited
            Queue<string> queue=new Queue<string>();
            queue.Enqueue(beginWord);

            //BFS
             int step=0;
            while(queue.Count>0){
                int size=queue.Count;
                while(size-->0){
                    string currentWord=queue.Dequeue();

                    if(currentWord==endWord)
                        return step+1;
                    for(int i=0;i<currentWord.Length;i++){//遍历所有字符
                        for(char c='a';c<='z';c++){
                            string newWord=currentWord.Substring(0,i)+c+currentWord.Substring(i+1);
                            if(wordSet.Contains(newWord)){
                                queue.Enqueue(newWord);
                                
                                wordSet.Remove(newWord);
                            }
                        }
                    }
                }
                step++;    
            }
            return 0;
        }

        public int LadderLength1(string beginWord, string endWord, IList<string> wordList) {
            HashSet<string> wordSet=new HashSet<string>(wordList);

            if(wordList.Count==0||!wordSet.Contains(endWord)){
                return 0;
            }
            wordSet.Remove(beginWord);

            //广度搜索：使用队列和visited
            Queue<string> queue=new Queue<string>();
            queue.Enqueue(beginWord);

            HashSet<string> visited=new HashSet<string>();
            visited.Add(beginWord);

            //BFS
            int step=1;
            while(queue.Count>0){
                int currentSize=queue.Count;
                for(int i=0;i<currentSize;i++){
                    string currentWord=queue.Dequeue();

                    foreach(var s in wordList){
                        if(visited.Contains(s))
                            continue;
                        
                        //不能跳过的
                        if(!CanConvert(currentWord, s))
                            continue;
                        
                        if(s==endWord){
                            return step++;
                        }
                        //保存访问过的单词，同时把单词放进队列，用于下一层的访问
                        visited.Add(s);
                        queue.Enqueue(s);
                    }

                    //if(ChangeWordEveryOneLetter(currentWord,endWord,queue,visited,wordSet))
                    //    return step+1;
                }
                //step++;
            }
            return 0;
        }

        //这个超时了
        private bool CanConvert(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;
            int count = 0;
            for (int i = 0; i < s1.Length; ++i) {
                if (s1[i]!= s2[i]) {
                    ++count;
                    if (count > 1) {
                        return false;
                    }
                }
             }
            return count == 1;
        }

        private bool ChangeWordEveryOneLetter(string currentWord, string endWord, Queue<string> queue, HashSet<string> visited, HashSet<string> wordSet)
        {
            char[] charArray=currentWord.ToCharArray();
            for(int i=0;i<endWord.Length;i++){
                char originChar=charArray[i];
                for(char k='a';k<='z';k++){
                    if(k==originChar){
                        continue;
                    }
                    charArray[i]=k;
                    string nextWord=charArray.ToString();
                    if(wordSet.Contains(nextWord)){
                        if(nextWord==endWord)
                            return true;
                    }
                    if(!visited.Contains(nextWord)){
                        queue.Enqueue(nextWord);
                        visited.Add(nextWord);
                    }
                }
                charArray[i]=originChar;
            }
            return false;
        }
    }
}