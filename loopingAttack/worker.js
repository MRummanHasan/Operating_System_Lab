var i = 0;
function startWorker(){
    var i = 0;
    while(i < 1000)
    {
        postMessage(i);
        i = i +1;
    }
}

startWorker();