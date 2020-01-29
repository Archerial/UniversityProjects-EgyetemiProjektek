<!DOCTPYE html>
<html>
    <head>
        <title>Login</title>
        <style type="text/css">
            *{
                margin:0;
                padding:0;
            }
            body{
                font-family: Calibri, sans-serif;
                margin: 0;
                padding: 0;

            }

            .background-wrap{
                position:fixed;
                z-index: -1000;
                width: 100%;
                height: 100%;
                overflow: hidden;
                top: 0;
                left: 0;

            }

            #video-bg-elem{
                position: absolute;
                top: 0;
                left: 0;
                min-height: 100%;
                min-width: 100%;

            }


            .box{
                position: absolute;
                top: 50%;
                left: 50%;
                transform: translate(-50%,-50%);
                width: 400px;
                background: rgba(0,0,0,.8);
                padding: 40px;
                box-sizing: border-box;
                box-shadow: 0 15px 25px rgba(0,0,0,.5);
                border-radius: 10px;
            }

            .box h1{
                margin:0 0 30px;
                padding:0;
                color: #fff;
                text-align: center;
            }

            .box .inputBox {
                position: relative;
            }

            .box .inputBox input{
                width: 100%;
                padding: 10px 0;
                font-size: 16px;
                color: #fff;
                letter-spacing: 2;
                margin-bottom: 30px;
                border: none;
                border-bottom: 1px solid #fff;
                outline: none;
                background: transparent;
            }

            .box .inputBox label{
                position:absolute;
                top: 0;
                left: 0;
                padding: 10px 0;
                font-size: 16px;
                color: #fff;
                pointer-events: none;
                transition: .5s;
            }

            .box .inputBox input:focus ~ label,
            .box .inputBox input:valid ~ label
            {
                top: -30px;
                left: 0;
                color: #dddf10;
                font-size: 12px;
            }

            .box input[type="submit"]{
                background: transparent;
                border: none;
                outline: none;
                color: #fff;
                background: #dddf10;
                padding:10px 20px;
                cursor: pointer;
                border-radius: 5px;


            }

        </style>
    </head>
<body>
    <div class="background-wrap">
        <video id="video-bg-elem" preload="auto" autoplay="true" loop="loop" muted="muted">
            <source src="bg.mp4" tpye="video/mp4">
            Video not supported
        </video>
    </div>

   
    <div class="box">
        <h1> Login </h1>
        <form>
            <div class="inputBox">
                <input type="text" name="" required="">
                <label> Username </label>
            </div>
            <div class="inputBox">
                <input type="password" name="" required="">
                <label>Password</label>
            </div>
            <input type="submit" name="" value="Submit">
        </form>
    </div>


</body>
</html>