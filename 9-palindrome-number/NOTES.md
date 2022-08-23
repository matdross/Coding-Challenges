%  gets the ones
/ 100 gets the 100s etc
​
%100 etc to remove top didget
/10 etc to remove smallest
​
​
Other code
```
int rev = 0;
while (x > rev) {
rev = rev*10 + x%10;
x = x/10;
}
return (x==rev || x==rev/10);
​
```