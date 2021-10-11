using System.Collections.Generic;
using System;

namespace algorithmHomework{

    public class LRUCache {
        private Dictionary<int,DLinkedNode> cache=new Dictionary<int, DLinkedNode>();
        private int size;
        private int capacity;
        private DLinkedNode head, tail;

        public LRUCache(int capacity) {
            this.capacity=capacity;
            this.size=0;
            head=new DLinkedNode();
            tail=new DLinkedNode();
            head.Next=tail;
            tail.Prev=head;
        }
        
        public int Get(int key) {
            if(!cache.ContainsKey(key))
                return -1;
            
            DLinkedNode node=cache[key];
            MoveToHead(node);
            return node.value;
        }
        
        public void Put(int key, int value) {
            if(cache.ContainsKey(key))
            {
                DLinkedNode node=cache[key];
                node.value=value;
                MoveToHead(node);               
            }
            else{
                DLinkedNode node=new DLinkedNode(key,value);
                cache.Add(key,node);
                AddToHead(node);
                ++size;
                if(size>capacity){
                    DLinkedNode tail=RemoveTail();
                    cache.Remove(tail.key);
                    --size;
                }
            }
        }

        private void AddToHead(DLinkedNode node) {
            node.Prev = head;
            node.Next = head.Next;
            head.Next.Prev = node;
            head.Next = node;
        }

        private void RemoveNode(DLinkedNode node) {
            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;
        }

        private void MoveToHead(DLinkedNode node) {
            RemoveNode(node);
            AddToHead(node);
        }

        private DLinkedNode RemoveTail() {
            DLinkedNode res = tail.Prev;
            RemoveNode(res);
            return res;
        }

    }

    class DLinkedNode {
        public int key;
        public int value;
        public DLinkedNode Prev;
        public DLinkedNode Next;
        public DLinkedNode() {}
        public DLinkedNode(int _key, int _value) {key = _key; value = _value;}
    }

}