O(2n) response not using har
​
if(head == null) return null;
var count = 0.0;
var cur = head;
while(cur.next != null) {
cur = cur.next;
count += 1;
}
count = count / 2;
​
cur = head;
for(int i = 0; i < count; i++) {
cur = cur.next;
}
return cur;