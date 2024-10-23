import os from 'os';

console.log('Platform:', os.platform());
console.log('CPU architecture:', os.arch());
console.log('Number of CPUs:', os.cpus().length);
