# Result from ab tests:

## Nancy 2.0 (clinteastwood)
```
ab -n 10 -c 10 -C "somecookie=rawr" http://localhost:3333/async
This is ApacheBench, Version 2.3 <$Revision: 1706008 $>
Copyright 1996 Adam Twiss, Zeus Technology Ltd, http://www.zeustech.net/
Licensed to The Apache Software Foundation, http://www.apache.org/

Benchmarking localhost (be patient).....done


Server Software:        Mono-HTTPAPI/1.0
Server Hostname:        localhost
Server Port:            3333

Document Path:          /async
Document Length:        12 bytes

Concurrency Level:      10
Time taken for tests:   50.180 seconds
Complete requests:      10
Failed requests:        0
Total transferred:      1540 bytes
HTML transferred:       120 bytes
Requests per second:    0.20 [#/sec] (mean)
Time per request:       50180.032 [ms] (mean)
Time per request:       5018.003 [ms] (mean, across all concurrent requests)
Transfer rate:          0.03 [Kbytes/sec] received

Connection Times (ms)
              min  mean[+/-sd] median   max
Connect:        0    0   0.1      0       1
Processing:  5166 27673 15142.5  30174   50179
Waiting:     5165 27673 15142.6  30174   50179
Total:       5166 27673 15142.4  30174   50179

Percentage of the requests served within a certain time (ms)
  50%  30174
  66%  35176
  75%  40177
  80%  45178
  90%  50179
  95%  50179
  98%  50179
  99%  50179
 100%  50179 (longest request)
```


## Nancy 1.4
```
ab -n 10 -c 10 -C "somecookie=rawr" http://localhost:3333/async
This is ApacheBench, Version 2.3 <$Revision: 1706008 $>
Copyright 1996 Adam Twiss, Zeus Technology Ltd, http://www.zeustech.net/
Licensed to The Apache Software Foundation, http://www.apache.org/

Benchmarking localhost (be patient).....done


Server Software:        Mono-HTTPAPI/1.0
Server Hostname:        localhost
Server Port:            3333

Document Path:          /async
Document Length:        12 bytes

Concurrency Level:      10
Time taken for tests:   5.010 seconds
Complete requests:      10
Failed requests:        0
Total transferred:      1380 bytes
HTML transferred:       120 bytes
Requests per second:    2.00 [#/sec] (mean)
Time per request:       5010.460 [ms] (mean)
Time per request:       501.046 [ms] (mean, across all concurrent requests)
Transfer rate:          0.27 [Kbytes/sec] received

Connection Times (ms)
              min  mean[+/-sd] median   max
Connect:        0    0   0.1      0       1
Processing:  5002 5004   3.6   5003    5010
Waiting:     5002 5004   3.6   5003    5010
Total:       5002 5005   3.5   5003    5010

Percentage of the requests served within a certain time (ms)
  50%   5003
  66%   5003
  75%   5009
  80%   5010
  90%   5010
  95%   5010
  98%   5010
  99%   5010
 100%   5010 (longest request)
```
