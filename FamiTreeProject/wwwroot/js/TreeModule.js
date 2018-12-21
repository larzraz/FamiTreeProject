var imghit;
var img = document.getElementById('hint');
var hintcounter = 0;
$(function () {
    org_chart = $('#orgChart').orgChart({
        data: dataForOrgChart,
        showControls: true,
        allowEdit: true,
        onAddNode: function (node) {
            log('Created new node on node ' + node.data.id);
            org_chart.newNode(node.data.id);
            $.ajax(
                {
                    type: "Post",
                    url: "Home/Post",
                    data: {
                        id: node.data.id,
                        name: node.data.name,
                        parent: node.data.parent
                    }
                });
        },
        onDeleteNode: function (node) {
            log('Deleted node ' + node.data.id);
            org_chart.deleteNode(node.data.id);
        },
        onClickNode: function (node) {
            log('Clicked node ' + node.data.id);
            imghit = node.data.id;
            tester.innerText = "Forkert";
            if
            ("persona " + imghit == img.attributes[1].value) {
                tester.innerText = node.data.name;
            } else {
                hintcounter++
                if (hintcounter == 1)
                    hint1.innerText = "Generation";
                if (hintcounter == 2)
                    hint2.innerText = "Lydfil";
                if (hintcounter == 3)
                    hint3.innerText = "Videofil";
                if (hintcounter >= 4)
                    hint4.innerText = "Præsentation";
            }
        }
    });
});
// just for example purpose
function log(text) {
    $('#consoleOutput').append('<p>' + text + '</p>')
}

var _gaq = _gaq || [];
_gaq.push(['_setAccount', 'UA-36251023-1']);
_gaq.push(['_setDomainName', 'jqueryscript.net']);
_gaq.push(['_trackPageview']);

(function () {
    var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
    ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
    var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
})();

