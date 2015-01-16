## Workload

### Web service
  - [Rubis](http://rubis.ow2.org/)
    - target response time: 150ms
    - service time: 12ms for each request
    - client arrival: exponential
    - inter arrival: lognormal distribution with mean 100ms

### Batch jobs
- [Map Reduce Job](http://ieeexplore.ieee.org/xpls/abs_all.jsp?arnumber=5493490)
  - Mean measured service time: 10 minutes
  - Max service time: 20 min
  - Mean arrival time: 2 min

### Setting
- Server: 2VM, each has 4 cores, in total 8 cores
  - 5 cores for MapReduce
