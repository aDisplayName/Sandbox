# Check if the path is rooted or fully qualified.

Whether the path is rooted or fully qualified are system dependent.

For following four different path string
*  C:/a/b.txt
*  C:a/b.txt
*  /a/b.txt
*  a/b.txt

The result is different. 

__On Mac / dotnet core 3.0 docker runtime image__

```
path: C:/a/b.txt IsRooted False; IsFullyQualified False
path: C:a/b.txt IsRooted False; IsFullyQualified False
path: /a/b.txt IsRooted True; IsFullyQualified True
path: a/b.txt IsRooted False; IsFullyQualified False
```

__On Windows 10__

```
path: C:/a/b.txt IsRooted True; IsFullyQualified True
path: C:a/b.txt IsRooted True; IsFullyQualified False
path: /a/b.txt IsRooted True; IsFullyQualified False
path: a/b.txt IsRooted False; IsFullyQualified False
```


