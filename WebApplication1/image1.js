
var index = 0;
function ChangeImg() {
    index++;
    var a = document.getElementsByClassName("img-slide");
    if (index > a.length) index = 0;
    for (var i = 0; i <= a.length; i++) {
        a[i].style.display = 'none';
    }
    a[index].style.display = 'block';
}
// ���ö�ʱ����ÿ�������л�һ��ͼƬ����ʼ����Ч��  
setInterval(function () {
    ChangeImg();
    // ������´�������������Ч��
    setTimeout(function () {
        document.querySelector('.img-slide').style.opacity = 1;
    }, 200);  // ���ʱ��Ӧ����ʵ��������е�������������Ϊ10���룬�Ա�֤���л�ͼƬ��������ʼ����Ч���������������ﵽ���͸���ȣ��Ӷ�ʵ��ƽ�����ɵ�Ч����
}, 3000);  // ÿ��3���л�һ��ͼƬ��ͬʱ��������Ч�������ʱ����Ը���ʵ��������е�����