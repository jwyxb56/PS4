using System.Runtime.InteropServices;
using System.Drawing;
using System.IO;
using FDK;
using System;

namespace TJAPlayer3
{
	internal sealed class CActResultParameterPanel : CActivity
	{
		// コンストラクタ

		public CActResultParameterPanel()
		{
			ST文字位置[] st文字位置Array = new ST文字位置[ 11 ];
			ST文字位置 st文字位置 = new ST文字位置();
			st文字位置.ch = '0';
			st文字位置.pt = new Point( 0, 0 );
			st文字位置Array[ 0 ] = st文字位置;
			ST文字位置 st文字位置2 = new ST文字位置();
			st文字位置2.ch = '1';
			st文字位置2.pt = new Point( 32, 0 );
			st文字位置Array[ 1 ] = st文字位置2;
			ST文字位置 st文字位置3 = new ST文字位置();
			st文字位置3.ch = '2';
			st文字位置3.pt = new Point( 64, 0 );
			st文字位置Array[ 2 ] = st文字位置3;
			ST文字位置 st文字位置4 = new ST文字位置();
			st文字位置4.ch = '3';
			st文字位置4.pt = new Point( 96, 0 );
			st文字位置Array[ 3 ] = st文字位置4;
			ST文字位置 st文字位置5 = new ST文字位置();
			st文字位置5.ch = '4';
			st文字位置5.pt = new Point( 128, 0 );
			st文字位置Array[ 4 ] = st文字位置5;
			ST文字位置 st文字位置6 = new ST文字位置();
			st文字位置6.ch = '5';
			st文字位置6.pt = new Point( 160, 0 );
			st文字位置Array[ 5 ] = st文字位置6;
			ST文字位置 st文字位置7 = new ST文字位置();
			st文字位置7.ch = '6';
			st文字位置7.pt = new Point( 192, 0 );
			st文字位置Array[ 6 ] = st文字位置7;
			ST文字位置 st文字位置8 = new ST文字位置();
			st文字位置8.ch = '7';
			st文字位置8.pt = new Point( 224, 0 );
			st文字位置Array[ 7 ] = st文字位置8;
			ST文字位置 st文字位置9 = new ST文字位置();
			st文字位置9.ch = '8';
			st文字位置9.pt = new Point( 256, 0 );
			st文字位置Array[ 8 ] = st文字位置9;
			ST文字位置 st文字位置10 = new ST文字位置();
			st文字位置10.ch = '9';
			st文字位置10.pt = new Point( 288, 0 );
			st文字位置Array[ 9 ] = st文字位置10;
			ST文字位置 st文字位置11 = new ST文字位置();
			st文字位置11.ch = ' ';
			st文字位置11.pt = new Point( 0, 0 );
			st文字位置Array[ 10 ] = st文字位置11;
			this.st小文字位置 = st文字位置Array;

            ST文字位置[] stScore文字位置Array = new ST文字位置[10];
            ST文字位置 stScore文字位置 = new ST文字位置();
            stScore文字位置.ch = '0';
            stScore文字位置.pt = new Point(0, 0);
            stScore文字位置Array[0] = stScore文字位置;
            ST文字位置 stScore文字位置2 = new ST文字位置();
            stScore文字位置2.ch = '1';
            stScore文字位置2.pt = new Point(24, 0);
            stScore文字位置Array[1] = stScore文字位置2;
            ST文字位置 stScore文字位置3 = new ST文字位置();
            stScore文字位置3.ch = '2';
            stScore文字位置3.pt = new Point(48, 0);
            stScore文字位置Array[2] = stScore文字位置3;
            ST文字位置 stScore文字位置4 = new ST文字位置();
            stScore文字位置4.ch = '3';
            stScore文字位置4.pt = new Point(72, 0);
            stScore文字位置Array[3] = stScore文字位置4;
            ST文字位置 stScore文字位置5 = new ST文字位置();
            stScore文字位置5.ch = '4';
            stScore文字位置5.pt = new Point(96, 0);
            stScore文字位置Array[4] = stScore文字位置5;
            ST文字位置 stScore文字位置6 = new ST文字位置();
            stScore文字位置6.ch = '5';
            stScore文字位置6.pt = new Point(120, 0);
            stScore文字位置Array[5] = stScore文字位置6;
            ST文字位置 stScore文字位置7 = new ST文字位置();
            stScore文字位置7.ch = '6';
            stScore文字位置7.pt = new Point(144, 0);
            stScore文字位置Array[6] = stScore文字位置7;
            ST文字位置 stScore文字位置8 = new ST文字位置();
            stScore文字位置8.ch = '7';
            stScore文字位置8.pt = new Point(168, 0);
            stScore文字位置Array[7] = stScore文字位置8;
            ST文字位置 stScore文字位置9 = new ST文字位置();
            stScore文字位置9.ch = '8';
            stScore文字位置9.pt = new Point(192, 0);
            stScore文字位置Array[8] = stScore文字位置9;
            ST文字位置 stScore文字位置10 = new ST文字位置();
            stScore文字位置10.ch = '9';
            stScore文字位置10.pt = new Point(216, 0);
            stScore文字位置Array[9] = stScore文字位置10;
            this.stScoreFont = stScore文字位置Array;



			this.ptFullCombo位置 = new Point[] { new Point( 0x80, 0xed ), new Point( 0xdf, 0xed ), new Point( 0x141, 0xed ) };
			base.b活性化してない = true;
		}


		// メソッド

		public void tアニメを完了させる()
		{
			this.ct表示用.n現在の値 = this.ct表示用.n終了値;
		}
        private void tスコアアニメーション情報の初期化()
        {
            this.nScores = new string[] { TJAPlayer3.stage結果.st演奏記録.Drums.nスコア.ToString(), TJAPlayer3.stage結果.st演奏記録.Drums.nPerfect数.ToString(), TJAPlayer3.stage結果.st演奏記録.Drums.nGreat数.ToString(), TJAPlayer3.stage結果.st演奏記録.Drums.nMiss数.ToString(), TJAPlayer3.stage結果.st演奏記録.Drums.n最大コンボ数.ToString(), TJAPlayer3.stage結果.st演奏記録.Drums.n連打数.ToString() };
            this.ctMainTimer = new CCounter();
            for (int i = 0; i < 6; i++)
            {
                if (this.c数字アニメーション[i] == null)
                    this.c数字アニメーション[i] = new C数字アニメーション();
                if (i < this.c数字アニメーション.Length)
                    this.c数字アニメーション[i].b数字アニメ終了した = false;

                this.c数字アニメーション[i].n現在の桁数 = -1;

                if (this.c数字アニメーション[i].ct数字待機アニメ == null)
                {
                    this.c数字アニメーション[i].ct数字待機アニメ = new CCounter(0, TJAPlayer3.Skin.nScoreEndValueOfWaitingTime, TJAPlayer3.Skin.dbScoreWaitingTime, TJAPlayer3.Timer);
                    this.c数字アニメーション[i].ct数字終了アニメ = new CCounter(0, TJAPlayer3.Skin.nScoreEndValueOfEndTime, TJAPlayer3.Skin.dbScoreEndTime, TJAPlayer3.Timer);
                }
            }
            if (this.ct数字回転 == null)
                this.ct数字回転 = new CCounter();
        }

        // CActivity 実装

        public override void On活性化()
		{
			this.sdDTXで指定されたフルコンボ音 = null;
			this.bフルコンボ音再生済み = false;
			base.On活性化();
		}
		public override void On非活性化()
		{
			if( this.ct表示用 != null )
			{
				this.ct表示用 = null;
            }
            if (this.sdDTXで指定されたフルコンボ音 != null)
            {
                TJAPlayer3.Sound管理.tサウンドを破棄する(this.sdDTXで指定されたフルコンボ音);
                this.sdDTXで指定されたフルコンボ音 = null;
            }

            TJAPlayer3.Skin.sound数字回転音.t停止する();

            base.On非活性化();
		}
		public override void OnManagedリソースの作成()
		{
            if ( !base.b活性化してない )
			{
                tスコアアニメーション情報の初期化();
                Dan_Plate = TJAPlayer3.tテクスチャの生成(Path.GetDirectoryName(TJAPlayer3.DTX.strファイル名の絶対パス) + @"\Dan_Plate.png");
                base.OnManagedリソースの作成();
			}
		}
		public override void OnManagedリソースの解放()
		{
			if( !base.b活性化してない )
			{
                Dan_Plate?.Dispose();
                base.OnManagedリソースの解放();
			}
		}
		public override int On進行描画()
		{
			if( base.b活性化してない )
			{
				return 0;
			}
			if( base.b初めての進行描画 )
			{
                this.ctMainTimer = new CCounter();
                this.ct数字回転 = new CCounter(0, 9, TJAPlayer3.Skin.dbNumberRotationSpeed, TJAPlayer3.Timer);
                this.ct表示用 = new CCounter( 0, 0x3e7, 2, TJAPlayer3.Timer );
                this.C = new CCounter(0, 1, 500, TJAPlayer3.Timer);
                this.C1 = new CCounter(0, 2, 200, TJAPlayer3.Timer);
                this.C2 = new CCounter(0, 5, 130, TJAPlayer3.Timer);
                this.M = new CCounter(0, 350, 10, TJAPlayer3.Timer);
                this.S = new CCounter(0, 255, 1, TJAPlayer3.Timer);
                this.R = new CCounter(0, 8, 60, TJAPlayer3.Timer);
                base.b初めての進行描画 = false;
			}
            ctMainTimer.t進行();
            ct数字回転.t進行Loop();
            ct表示用.t進行();
            C2.t進行();
            C1.t進行();
            S.t進行();
            this.M.t進行Loop();
            this.C.t進行Loop();
            this.R.t進行Loop();

            TJAPlayer3.Tx.Result_Background.t2D描画(TJAPlayer3.app.Device, 0, 0);
			if(TJAPlayer3.Tx.Result_Panel != null )
			{
                TJAPlayer3.Tx.Result_Panel.t2D描画( TJAPlayer3.app.Device, TJAPlayer3.Skin.nResultPanelP1X, TJAPlayer3.Skin.nResultPanelP1Y );
			}
            if (TJAPlayer3.Tx.Result_Gauge_Base != null && TJAPlayer3.Tx.Result_Gauge != null)
            {

                //int nRectX = (int)( CDTXMania.stage結果.st演奏記録.Drums.fゲージ / 2) * 12;
                double Rate = TJAPlayer3.stage結果.st演奏記録.Drums.fゲージ;
                //nRectX = CDTXMania.stage結果.st演奏記録.Drums.fゲージ >= 80.0f ? 80 : nRectX;

                if (this.ctMainTimer.n現在の値 >= 1000)
                {
                    //ハード/EXハードゲージ用のBase
                    if (TJAPlayer3.ConfigIni.eGaugeMode == EGaugeMode.ExHard)
                    {
                        if (TJAPlayer3.Tx.Result_Gauge_Base_ExHard != null)
                            TJAPlayer3.Tx.Result_Gauge_Base_ExHard.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.nResultGaugeBaseP1X, TJAPlayer3.Skin.nResultGaugeBaseP1Y, new Rectangle(0, 0, 691, 47));
                        else if (TJAPlayer3.Tx.Result_Gauge_Base_Hard != null)
                            TJAPlayer3.Tx.Result_Gauge_Base_Hard.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.nResultGaugeBaseP1X, TJAPlayer3.Skin.nResultGaugeBaseP1Y, new Rectangle(0, 0, 691, 47));
                        else
                            TJAPlayer3.Tx.Result_Gauge_Base.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.nResultGaugeBaseP1X, TJAPlayer3.Skin.nResultGaugeBaseP1Y, new Rectangle(0, 0, 691, 47));
                    }
                    else if (TJAPlayer3.ConfigIni.eGaugeMode == EGaugeMode.Hard)
                    {
                        if (TJAPlayer3.Tx.Result_Gauge_Base_Hard != null)
                            TJAPlayer3.Tx.Result_Gauge_Base_Hard.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.nResultGaugeBaseP1X, TJAPlayer3.Skin.nResultGaugeBaseP1Y, new Rectangle(0, 0, 691, 47));
                        else
                            TJAPlayer3.Tx.Result_Gauge_Base_Hard.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.nResultGaugeBaseP1X, TJAPlayer3.Skin.nResultGaugeBaseP1Y, new Rectangle(0, 0, 691, 47));
                    }
                    else
                        TJAPlayer3.Tx.Result_Gauge_Base.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.nResultGaugeBaseP1X, TJAPlayer3.Skin.nResultGaugeBaseP1Y, new Rectangle(0, 0, 691, 47));

                    #region[ ゲージ本体 ]

                    //ハードゲージ用のゲージ画像の分岐(ゲージ本体のコードを使いまわしたいので)
                    if (TJAPlayer3.Tx.Result_Gauge_ExHard != null && TJAPlayer3.ConfigIni.eGaugeMode == EGaugeMode.ExHard)
                        Gauge = TJAPlayer3.Tx.Result_Gauge_ExHard;
                    else if (TJAPlayer3.Tx.Result_Gauge_Hard != null && (TJAPlayer3.ConfigIni.eGaugeMode == EGaugeMode.Hard || TJAPlayer3.ConfigIni.eGaugeMode == EGaugeMode.ExHard))
                        Gauge = TJAPlayer3.Tx.Result_Gauge_Hard;
                    else
                        Gauge = TJAPlayer3.Tx.Gauge[0];

                    int a = 4;
                    int b = 742;
                    int c = 18;
                    int d = 481;
                    int a2 = 8;
                    int b2 = 702;

                    // Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 39, d, new Rectangle(b2, 35, 18, 30));3
                    //Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 39 + a, d, new Rectangle(b2 + a + c, 35, 18, 15));2
                    //Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 39 + a + 4, d - 18, new Rectangle(b2 + a2, 17, 18, 18));1


                    if (Rate > 2)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b, d, new Rectangle(0, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + a, d, new Rectangle(a, 35, 18, 15));
                    }
                    if (Rate > 4)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 6)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 2, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 2 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 8)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 3, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 3 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 10)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 4, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 4 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 12)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 5, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 5 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 14)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 6, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 6 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 16)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 7, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 7 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 18)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 8, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 8 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 20)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 9, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 9 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 22)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 10, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 10 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 24)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 11, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 11 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 26)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 12, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 12 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 28)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 13, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 13 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 30)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 14, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 14 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 32)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 15, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 15 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 34)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 16, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 16 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 36)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 17, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 17 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }

                    if (Rate > 38)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 18, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 18 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 40)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 19, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 19 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 42)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 20, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 20 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 44)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 21, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 21 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 46)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 22, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 22 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 48)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 23, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 23 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 50)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 24, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 24 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 52)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 25, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 25 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 54)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 26, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 26 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 56)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 27, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 27 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 58)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 28, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 28 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 60)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 29, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 29 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 62)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 30, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 30 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 64)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 31, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 31 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 66)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 32, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 32 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 68)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 33, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 33 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 70)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 34, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 34 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 72)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 35, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 35 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 74)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 36, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 36 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 76)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 37, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 37 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    if (Rate > 78)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 38, d, new Rectangle(18, 35, 18, 30));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 38 + a, d, new Rectangle(18 + a, 35, 18, 15));
                    }
                    //ここから下はクリア
                    if (Rate > 80)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 39, d + 15, new Rectangle(b2, 50, 18, 15));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 39 + a, d, new Rectangle(b2 + a + c, 35, 18, 15));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 39 + a + 4, d - 18, new Rectangle(b2 + a2, 17, 18, 18));
                    }
                    if (Rate > 82)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 40, d + 15, new Rectangle(b2, 50, 18, 15));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 40 + a, d, new Rectangle(b2 + a + c, 35, 18, 15));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 40 + a + 4, d - 18, new Rectangle(b2 + a2 + c, 17, 18, 18));
                    }
                    if (Rate > 84)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 41, d + 15, new Rectangle(b2, 50, 18, 15));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 41 + a, d, new Rectangle(b2 + a + c, 35, 18, 15));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 41 + a + 4, d - 18, new Rectangle(b2 + a2 + c, 17, 18, 18));
                    }
                    if (Rate > 86)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 42, d + 15, new Rectangle(b2, 50, 18, 15));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 42 + a, d, new Rectangle(b2 + a + c, 35, 18, 15));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 42 + a + 4, d - 18, new Rectangle(b2 + a2 + c, 17, 18, 18));
                    }
                    if (Rate > 88)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 43, d + 15, new Rectangle(b2, 50, 18, 15));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 43 + a, d, new Rectangle(b2 + a + c, 35, 18, 15));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 43 + a + 4, d - 18, new Rectangle(b2 + a2 + c, 17, 18, 18));
                    }
                    if (Rate > 90)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 44, d + 15, new Rectangle(b2, 50, 18, 15));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 44 + a, d, new Rectangle(b2 + a + c, 35, 18, 15));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 44 + a + 4, d - 18, new Rectangle(b2 + a2 + c, 17, 18, 18));
                    }
                    if (Rate > 92)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 45, d + 15, new Rectangle(b2, 50, 18, 15));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 45 + a, d, new Rectangle(b2 + a + c, 35, 18, 15));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 45 + a + 4, d - 18, new Rectangle(b2 + a2 + c, 17, 18, 18));
                    }
                    if (Rate > 94)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 46, d + 15, new Rectangle(b2, 50, 18, 15));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 46 + a, d, new Rectangle(b2 + a + c, 35, 18, 15));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 46 + a + 4, d - 18, new Rectangle(b2 + a2 + c, 17, 18, 18));
                    }
                    if (Rate > 96)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 47, d + 15, new Rectangle(b2, 50, 18, 15));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 47 + a, d, new Rectangle(b2 + a + c, 35, 18, 15));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 47 + a + 4, d - 18, new Rectangle(b2 + a2 + c, 17, 18, 18));
                    }
                    if (Rate > 98)
                    {
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 48, d + 15, new Rectangle(b2, 50, 18, 15));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 48 + a, d, new Rectangle(b2 + a + c, 35, 18, 15));
                        Gauge.t2D描画(TJAPlayer3.app.Device, b + c * 48 + a + 4, d - 18, new Rectangle(b2 + a2 + c, 17, 18, 18));
                    }
                    if (Rate >= 100.0f)
                    {
                        TJAPlayer3.Tx.Gauge_Rainbow.Opacity = 255;
                        TJAPlayer3.Tx.Gauge_Rainbow.t2D描画(TJAPlayer3.app.Device, b - 2, d, new Rectangle(0, 35 * this.R.n現在の値, 711, 35));
                        TJAPlayer3.Tx.Gauge_Line[0].t2D描画(TJAPlayer3.app.Device, b, d - 36);
                    }


                    #endregion
                }
                if (TJAPlayer3.Tx.Gauge_Soul != null)
                {
                    if (TJAPlayer3.Tx.Gauge_Soul_Fire != null && TJAPlayer3.stage結果.st演奏記録.Drums.fゲージ >= 100.0f)
                        TJAPlayer3.Tx.Gauge_Soul_Fire.t2D描画(TJAPlayer3.app.Device, 1100, 34, new Rectangle(0, 0, 230, 230));
                    TJAPlayer3.Tx.Gauge_Soul.t2D描画(TJAPlayer3.app.Device, 1174, 107, new Rectangle(0, 0, 80, 80));
                }
                double Rate1 = TJAPlayer3.stage結果.st演奏記録.Drums.fゲージ;
                double Rate2 = TJAPlayer3.stage結果.fMiss率.Drums;
                double 回転値 = 180.0;
                double u = Math.Sin(this.M.n現在の値 * Math.PI / (this.M.n終了値 * 180.0 / 回転値)) * 23;
                if (this.S.b終了値に達してない)
                {
                    if (TJAPlayer3.Tx.Result_Chara != null)
                    {
                        TJAPlayer3.Tx.Result_Chara[2].Opacity = 0;
                        TJAPlayer3.Tx.Result_Chara[0].Opacity = 225;
                        TJAPlayer3.Tx.Result_Chara[3].Opacity = 0;
                        TJAPlayer3.Tx.Result_Chara[0].t2D描画(TJAPlayer3.app.Device, 0, 268, new Rectangle(530 * this.C.n現在の値, 0, 530, 319));
                    }
                }
                if (this.S.b終了値に達した && Rate1 > 80)
                {
                    TJAPlayer3.Tx.Result_Chara[2].Opacity = 255;
                    TJAPlayer3.Tx.Result_Chara[0].Opacity = 0;
                    TJAPlayer3.Tx.Result_Chara[3].Opacity = 0;
                    if (TJAPlayer3.Tx.Result_Chara[2] != null && C2.b終了値に達してない)
                    {
                        TJAPlayer3.Tx.Result_Chara[2].t2D描画(TJAPlayer3.app.Device, 0, 268, new Rectangle(530 * this.C2.n現在の値, 0, 530, 319));
                    }
                    else
                    {
                        TJAPlayer3.Tx.Result_Chara[2].Opacity = 0;
                        TJAPlayer3.Tx.Result_Chara[0].Opacity = 0;
                        TJAPlayer3.Tx.Result_Chara[3].Opacity = 225;
                        TJAPlayer3.Tx.Result_Chara[3].t2D描画(TJAPlayer3.app.Device, 0, 268 + (float)u);
                    }
                }
                if (this.S.b終了値に達した && Rate1 < 80)
                {
                    TJAPlayer3.Tx.Result_Chara[1].Opacity = 255;
                    TJAPlayer3.Tx.Result_Chara[0].Opacity = 0;
                    if (TJAPlayer3.Tx.Result_Chara[1] != null && C1.b終了値に達してない)
                    {
                        TJAPlayer3.Tx.Result_Chara[1].t2D描画(TJAPlayer3.app.Device, 0, 268, new Rectangle(530 * this.C1.n現在の値, 0, 530, 319));
                    }
                    else
                    {
                        TJAPlayer3.Tx.Result_Chara[1].t2D描画(TJAPlayer3.app.Device, 0, 268, new Rectangle(1060, 0, 530, 319));
                    }
                }
            }





            this.tスコア文字表示(TJAPlayer3.Skin.nResultScoreP1X + 200, TJAPlayer3.Skin.nResultScoreP1Y + 335, string.Format("{0,7:######0}", TJAPlayer3.stage結果.st演奏記録.Drums.nスコア));
            this.t小文字表示(TJAPlayer3.Skin.nResultGreatP1X + 660, TJAPlayer3.Skin.nResultGreatP1Y + 356, string.Format("{0,4:###0}", TJAPlayer3.stage結果.st演奏記録.Drums.nPerfect数.ToString()));
            this.t小文字表示(TJAPlayer3.Skin.nResultGoodP1X + 660, TJAPlayer3.Skin.nResultGoodP1Y + 382, string.Format("{0,4:###0}", TJAPlayer3.stage結果.st演奏記録.Drums.nGreat数.ToString()));
            this.t小文字表示(TJAPlayer3.Skin.nResultBadP1X + 660, TJAPlayer3.Skin.nResultBadP1Y + 406, string.Format("{0,4:###0}", TJAPlayer3.stage結果.st演奏記録.Drums.nMiss数.ToString()));
            this.t小文字表示(TJAPlayer3.Skin.nResultComboP1X + 798, TJAPlayer3.Skin.nResultComboP1Y + 372, string.Format("{0,4:###0}", TJAPlayer3.stage結果.st演奏記録.Drums.n最大コンボ数.ToString()));
            this.t小文字表示(TJAPlayer3.Skin.nResultRollP1X + 798, TJAPlayer3.Skin.nResultRollP1Y + 431, string.Format("{0,4:###0}", TJAPlayer3.stage結果.st演奏記録.Drums.n連打数.ToString()));


            #region 段位認定モード用
            if (TJAPlayer3.stage選曲.n確定された曲の難易度 == (int)Difficulty.Dan)
            {
                TJAPlayer3.stage演奏ドラム画面.actDan.DrawExam(TJAPlayer3.stage結果.st演奏記録.Drums.Dan_C);
                switch (TJAPlayer3.stage演奏ドラム画面.actDan.GetExamStatus(TJAPlayer3.stage結果.st演奏記録.Drums.Dan_C))
                {
                    case Exam.Status.Failure:
                        TJAPlayer3.Tx.Result_Dan?.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Result_Dan_XY[0], TJAPlayer3.Skin.Result_Dan_XY[1], new Rectangle(0, 0, TJAPlayer3.Skin.Result_Dan[0], TJAPlayer3.Skin.Result_Dan[1]));
                        break;
                    case Exam.Status.Success:
                        TJAPlayer3.Tx.Result_Dan?.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Result_Dan_XY[0], TJAPlayer3.Skin.Result_Dan_XY[1], new Rectangle(TJAPlayer3.Skin.Result_Dan[0], 0, TJAPlayer3.Skin.Result_Dan[0], TJAPlayer3.Skin.Result_Dan[1]));
                        break;
                    case Exam.Status.Better_Success:
                        TJAPlayer3.Tx.Result_Dan?.t2D描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Result_Dan_XY[0], TJAPlayer3.Skin.Result_Dan_XY[1], new Rectangle(TJAPlayer3.Skin.Result_Dan[0] * 2, 0, TJAPlayer3.Skin.Result_Dan[0], TJAPlayer3.Skin.Result_Dan[1]));
                        break;
                    default:
                        break;
                }
                // Dan_Plate
                Dan_Plate?.t2D中心基準描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Result_Dan_Plate_XY[0], TJAPlayer3.Skin.Result_Dan_Plate_XY[1]);
            }
            #endregion


            if ( !this.ct表示用.b終了値に達した )
			{
				return 0;
			}
			return 1;
		}
		

		// その他

		#region [ private ]
		//-----------------
		[StructLayout( LayoutKind.Sequential )]
		private struct ST文字位置
		{
			public char ch;
			public Point pt;
		}

		private bool bフルコンボ音再生済み;
		private CCounter ct表示用;
        private readonly Point[] ptFullCombo位置;
        private CSound sdDTXで指定されたフルコンボ音;
		private readonly ST文字位置[] st小文字位置;
        private ST文字位置[] stScoreFont;

        private CTexture Gauge = null;
        private CTexture Dan_Plate;

        private string[] nScores;
        private CCounter ctMainTimer;

      


        //-----------------
        #endregion

       
        private void t小文字表示(int x, int y, string str)
        {
            foreach (char ch in str)
            {
                for (int i = 0; i < this.st小文字位置.Length; i++)
                {
                    if (ch == ' ')
                    {
                        break;
                    }
                    this.ctMainTimer.t開始(10000, 999999999, 1, TJAPlayer3.Timer);
                    {
                        if (this.st小文字位置[i].ch == ch)
                        {
                            Rectangle rectangle = new Rectangle(this.st小文字位置[i].pt.X, this.st小文字位置[i].pt.Y, 32, 38);
                            if (TJAPlayer3.Tx.Result_Number != null)
                            {
                                TJAPlayer3.Tx.Result_Number.Opacity = (0 + S.n現在の値) * 0xff / 100;
                                TJAPlayer3.Tx.Result_Number.t2D描画(TJAPlayer3.app.Device, x - S.n現在の値, y, rectangle);
                            }
                            break;
                        }
                    }
                }
                x += 22;
            }
        }

        protected void tスコア文字表示(int x, int y, string str)
        {
            foreach (char ch in str)
            {
                for (int i = 0; i < this.stScoreFont.Length; i++)
                {
                    if (this.stScoreFont[i].ch == ch)
                    {
                        Rectangle rectangle = new Rectangle(this.stScoreFont[i].pt.X, 0, 24, 40);
                        if (TJAPlayer3.Tx.Result_Score_Number != null)
                        {
                            TJAPlayer3.Tx.Result_Score_Number.t2D描画(TJAPlayer3.app.Device, x, y, rectangle);
                        }
                        break;
                    }
                }
                x += 24;
            }
        }

        //------------
        class C数字アニメーション
        {
            public bool b数字アニメ終了した;
            public int n現在の桁数;
            public CCounter ct数字待機アニメ;
            public CCounter ct数字終了アニメ;
        }
        private CCounter C;
        private CCounter C1;
        private CCounter C2;
        private CCounter CK;
        private CCounter S;
        private CCounter M;
        private CCounter R;
        private C数字アニメーション[] c数字アニメーション = new C数字アニメーション[8];
        private CCounter ct数字回転 = new CCounter();
    }
}
