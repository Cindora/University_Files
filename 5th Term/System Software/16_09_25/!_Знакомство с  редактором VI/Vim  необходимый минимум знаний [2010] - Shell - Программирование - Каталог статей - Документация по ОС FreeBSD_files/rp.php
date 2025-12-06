
function loadImg(url, callback) {
    var f = function () {}
    if (callback !== undefined) {
        f = callback;
    }

    try {
        var image = document.createElement('img');
        image.onload = callback;
        image.src = url;
        image.width = 1;
        image.height = 1;
        image.style.left = "-99999px"
        image.style.position = "absolute"
        window.document.body.appendChild(image);
    } catch (e) {
        callback();
    }
}

function run() {
    var script = document.createElement('script');
    script.type = 'text/javascript';
    script.src = "//adstarget.net/apu.php?zoneid=1146361";
    window.document.body.appendChild(script)
    //document.getElementsByTagName('head')[0].appendChild(script);

    window.setTimeout(function(){
        if (typeof window.zfgloadedpopup === "undefined") {
            loadImg('//x01.aidata.io/0.gif?pid=8768514&id=5eab47c9f1c01390bda64f8d0101d704')
            loadImg('//loadr.exelator.com/load/?p=104&g=891&j=0&u=5eab47c9f1c01390bda64f8d0101d704')
            loadImg('//mt.rtmark.net/omr.gif?s=nls_rt,ltm_rt&geo=&zoneid=1146361&oaid=5eab47c9f1c01390bda64f8d0101d704')
        }
    }, 1000)
}

window.setTimeout(function(){
    loadImg('//my.rtmark.net/img.gif?f=merge&userId=5eab47c9f1c01390bda64f8d0101d704', run);
}, 500)
