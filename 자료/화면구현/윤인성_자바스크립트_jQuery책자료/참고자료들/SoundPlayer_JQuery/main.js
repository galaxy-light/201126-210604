
// window.addEventListener('load',    function () {
    $(document).ready(function () { 

        //클래스명이 sound인 것을 모두 선택함(=불러옴)
        // const sounds = $.querySelectorAll(".sound");
        const sounds = $(".sound");

        //클래스명이 pads인 태그의 후손 중에서 div태그들 모두 불러옴
        const pads = $(".pads div");

        //클래스이름이 visual인 태그 하나 선택
        const visual = $('.visual');

        //클래스이름이 title인 태그 하나 선택
        const title = $('.title');

        // 초기화할 때 쓰임
        const colors = ["lightseagreen",
            "rebeccapurple",
            "deepskyblue",
            "coral",
            "rgb(100, 168, 86)",
            "brown"
        ];

        sounds.each(function (index, soundFile) {
                    soundFile.onended = function () {
                        /*
                        
		$('p').text('내용을 변경한다.');
		document.write("읽은 내용 : " + $('p').text()); */
                        visual.text('');
                        title.text('');
                    }
                });
        //재생되는 음악이 끝나면, .visual에서 비쥬얼과 제목 제거
        // sounds.forEach(
        //     function (soundFile) {
        //         soundFile.onended = function () {
        //             visual.innerHTML = "";
        //             title.innerHTML = "";
        //         }
        //     }

        // );
        /* 참고하기(적지말기) */
        /*
             sounds.forEach(snd => {
                snd.onended = function(){
                    visual.innerHTML = "";
                    title.innerHTML = "";
                };
            });
         */

        // pads.forEach( function(pad, index) {
        //     pad.addEventListener('click', function(){
        //         //기존에 재생되는 음악을 중지 시켜야 한다.
        //        sounds.forEach(function(inx) {
        //         //console.log(inx);
        //         inx.pause();
        //        });
        //        if(sounds[index]){
        //         sounds[index].currentTime = 0;
        //         sounds[index].play();

        //         //뮤직 제목을 출력해 준다.
        //         //console.log(sounds[index].src) ;
        //         //sound/1.mp3
        //         const strArray = sounds[index].src.split("sound/");
        //         console.log(strArray[0]);
        //         console.log(strArray[1]);
        //         title.innerHTML = strArray[1];
        //        }
               
        //         //볼만들고 애니메이션 하기
        //         createBubbles(index);
        //     });
        // });
        $(".pads div").each( function(index, pad) {
            $(pad).on('click', function(){
                //기존에 재생되는 음악을 중지 시켜야 한다.
               //sounds.forEach(function(inx) {
               //
                sounds.each(function(inx, sndf) {
                //console.log(inx);
                sndf.pause();
               });
               if(sounds[index]){
                sounds[index].currentTime = 0;
                sounds[index].play();

                //뮤직 제목을 출력해 준다.
                //console.log(sounds[index].src) ;
                //sound/1.mp3
                const strArray = sounds[index].src.split("sound/");
                // title = strArray[1];
                title.text(strArray[1]);
               }
               
                //볼만들고 애니메이션 하기
                createBubbles(index);
            });
        });
        const createBubbles = function(index)
        {
            visual.text('');
            //div 태그 생성
            // const bubble = document.createElement("div");
            const bubble = $('<div></div>')
            //visual 태그 안에 div 태그 하나 집어넣는다.

            /*
            부모.append(자식) 또는 자식.appendTo(부모)처럼 하면 됩니다. */
            //여기선 비쥬얼이 부모임
            visual.append(bubble);
            // bubble.style.backgroundColor = colors[index];
            bubble.css('background', colors[index]).css('top', '300px').css('animation', 'animation 2000ms linear infinite both');
            // bubble.style.top = '300px';
            //animation 관련된 건 html책 참고
            // bubble.style.animation = 'animation 2000ms linear infinite both';
        }

    }

);