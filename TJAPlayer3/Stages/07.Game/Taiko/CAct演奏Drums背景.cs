using System;
using FDK;
using System.Runtime.InteropServices;
using System.Drawing;

namespace TJAPlayer3
{
    internal class CAct演奏Drums背景 : CActivity
    {
        public CAct演奏Drums背景()
        {
            base.b活性化してない = true;
        }

        public void ClearIn(int player)
        {
            this.ct上背景クリアインタイマー[player] = new CCounter(0, 100, 2, TJAPlayer3.Timer);
            this.ct上背景クリアインタイマー[player].n現在の値 = 0;
            this.ct上背景FIFOタイマー = new CCounter(0, 250, 2, TJAPlayer3.Timer);
            this.ct上背景FIFOタイマー.n現在の値 = 0;
        }

        public override void On非活性化()
        {
            ct上背景FIFOタイマー = null;

            for (int i = 0; i < 2; i++)
            {
                ct上背景スクロール用タイマー[i] = null;
            }

            ct下背景スクロール用タイマー1 = null;

            base.On非活性化();
        }

        public override void OnManagedリソースの作成()
        {
            this.ct上背景スクロール用タイマー = new CCounter[2];
            this.上下 = new CCounter[2];
            this.ct上背景クリアインタイマー = new CCounter[2];
            for (int i = 0; i < 2; i++)
            {
                if (TJAPlayer3.Tx.Background_Down[i] != null)
                {
                    this.ct上背景スクロール用タイマー[i] = new CCounter(1, TJAPlayer3.Tx.Background_Down[i].szテクスチャサイズ.Width, 16, TJAPlayer3.Timer);
                    this.上下[i] = new CCounter(1, 80, 26, TJAPlayer3.Timer);
                    this.ct上背景クリアインタイマー[i] = new CCounter();
                }
            }
            if (TJAPlayer3.Tx.Background_DownC != null)
                this.ct下背景スクロール用タイマー1 = new CCounter( 1, 66, 24, TJAPlayer3.Timer );
            this.ct下背景スクロール用タイマー2 = new CCounter(1, 410, 16, TJAPlayer3.Timer);
            this.ct下背景スクロール用タイマー3 = new CCounter(1, 410, 16, TJAPlayer3.Timer);
            this.ct下背景スクロール用タイマー4 = new CCounter(0, 490, 12, TJAPlayer3.Timer);
            this.ct下背景スクロール用タイマー5 = new CCounter(0, 980, 16, TJAPlayer3.Timer);
            this.ct = new CCounter(0, 45, 30, TJAPlayer3.Timer);
            this.ct上背景FIFOタイマー = new CCounter();
            base.OnManagedリソースの作成();
        }

        public override int On進行描画()
        {
            this.ct上背景FIFOタイマー.t進行();
            
            for (int i = 0; i < 2; i++)
            {
                if(this.ct上背景クリアインタイマー[i] != null)
                   this.ct上背景クリアインタイマー[i].t進行();
            }
            for (int i = 0; i < 2; i++)
            {
                if (this.ct上背景スクロール用タイマー[i] != null)
                    this.ct上背景スクロール用タイマー[i].t進行Loop();
            }
            if (this.ct下背景スクロール用タイマー1 != null && this.ct下背景スクロール用タイマー2 != null && this.ct下背景スクロール用タイマー3 != null)
            {
                this.ct下背景スクロール用タイマー1.t進行Loop();
                this.ct下背景スクロール用タイマー3.t進行Loop();
                this.ct下背景スクロール用タイマー2.t進行Loop();
                this.ct下背景スクロール用タイマー4.t進行Loop();
                this.ct下背景スクロール用タイマー5.t進行Loop();
            }
            #region 1P-背景
            if ( !TJAPlayer3.stage演奏ドラム画面.bDoublePlay )
            {
                if (TJAPlayer3.ConfigIni.eGameMode == EGame.特訓モード)
                {

                }
                if (TJAPlayer3.stage演奏ドラム画面.actGauge.db現在のゲージ値[0] < 80)
                {
                    if (TJAPlayer3.Tx.Background_Down[0] != null)
                    {
                        TJAPlayer3.Tx.Background_Down[0].t2D中心基準描画(TJAPlayer3.app.Device, 960, 540, new Rectangle(0, 0, 1920, 1080));
                    }
                    if (TJAPlayer3.stage演奏ドラム画面.actGauge.db現在のゲージ値[0] >= 40)
                    {
                        #region [桜]
                        double TexSize = 2400 / TJAPlayer3.Tx.Background_Down[1].szテクスチャサイズ.Width;
                        int ForLoop = (int)Math.Ceiling(TexSize) + 1;
                        TJAPlayer3.Tx.Background_Down[1].t2D中心基準描画(TJAPlayer3.app.Device, -410 - this.ct下背景スクロール用タイマー2.n現在の値, -410 + this.ct下背景スクロール用タイマー3.n現在の値);
                        TJAPlayer3.Tx.Background_Down[1].t2D中心基準描画(TJAPlayer3.app.Device, -410 - this.ct下背景スクロール用タイマー2.n現在の値, 0 + this.ct下背景スクロール用タイマー3.n現在の値);
                        TJAPlayer3.Tx.Background_Down[1].t2D中心基準描画(TJAPlayer3.app.Device, -410 - this.ct下背景スクロール用タイマー2.n現在の値, 410 + this.ct下背景スクロール用タイマー3.n現在の値);
                        TJAPlayer3.Tx.Background_Down[1].t2D中心基準描画(TJAPlayer3.app.Device, -410 - this.ct下背景スクロール用タイマー2.n現在の値, 820 + this.ct下背景スクロール用タイマー3.n現在の値);
                        for (int l = 1; l < ForLoop + 1; l++)
                        {
                            TJAPlayer3.Tx.Background_Down[1].t2D描画(TJAPlayer3.app.Device, -410 + (l * TJAPlayer3.Tx.Background_Down[1].szテクスチャサイズ.Width) - this.ct下背景スクロール用タイマー2.n現在の値, -410 + this.ct下背景スクロール用タイマー3.n現在の値);
                            TJAPlayer3.Tx.Background_Down[1].t2D描画(TJAPlayer3.app.Device, -410 + (l * TJAPlayer3.Tx.Background_Down[1].szテクスチャサイズ.Width) - this.ct下背景スクロール用タイマー2.n現在の値, 0 + this.ct下背景スクロール用タイマー3.n現在の値);
                            TJAPlayer3.Tx.Background_Down[1].t2D描画(TJAPlayer3.app.Device, -410 + (l * TJAPlayer3.Tx.Background_Down[1].szテクスチャサイズ.Width) - this.ct下背景スクロール用タイマー2.n現在の値, 410 + this.ct下背景スクロール用タイマー3.n現在の値);
                            TJAPlayer3.Tx.Background_Down[1].t2D描画(TJAPlayer3.app.Device, -410 + (l * TJAPlayer3.Tx.Background_Down[1].szテクスチャサイズ.Width) - this.ct下背景スクロール用タイマー2.n現在の値, 820 + this.ct下背景スクロール用タイマー3.n現在の値);
                        }
                        #endregion
                    }
                }
                if (TJAPlayer3.stage演奏ドラム画面.bIsAlreadyCleared[0] && TJAPlayer3.ConfigIni.eGaugeMode != EGaugeMode.Hard && TJAPlayer3.ConfigIni.eGaugeMode != EGaugeMode.ExHard)
                {
                    if (TJAPlayer3.Tx.Background_DownC != null && this.ct != null)
                    {
                        //X = 動かしたい距離　Y = 移動距離を何倍にしたいか　カウンターの値 = X + X * Y
                        //int n = 0; if(n.timer. <= X), n = n.timer; , else {n = X - (カウンターの値 - X) / (カウンターの値終了値 - X) / X;
                        this.ct.t進行Loop();
                        int c = 0;
                        if (this.ct.n現在の値 <= 30)
                        {
                            c = ct.n現在の値;
                        }
                        else
                        {
                            c = (30 - (ct.n現在の値 - 30) * 2);
                        }
                        TJAPlayer3.Tx.Background_DownC[0].Opacity = ((this.ct上背景FIFOタイマー.n現在の値 * 0xff) / 100);
                        double TexSize = 1920 / 66;
                        int ForLoop = (int)Math.Ceiling(TexSize) + 1;
                        double TexSize1 = 2400 / 490;
                        int ForLoop1 = (int)Math.Ceiling(TexSize1) + 1;
                        double TexSize2 = 2400 / 980;
                        int ForLoop2 = (int)Math.Ceiling(TexSize2) + 1;
                        TJAPlayer3.Tx.Background_DownC[0].t2D描画(TJAPlayer3.app.Device, 0 - this.ct下背景スクロール用タイマー1.n現在の値, 0, new Rectangle(0, 2188, 66, 738));
                        for (int l = 1; l < ForLoop + 1; l++)
                        {
                            TJAPlayer3.Tx.Background_DownC[0].t2D描画(TJAPlayer3.app.Device, +(l * 66) - this.ct下背景スクロール用タイマー1.n現在の値, 0, new Rectangle(0, 2188, 66, 738));
                        }
                        //富士
                        TJAPlayer3.Tx.Background_DownC[0].t2D描画(TJAPlayer3.app.Device, 0, 0, new Rectangle(1922, 1510, 1922, 678));

                        //大波
                        TJAPlayer3.Tx.Background_DownC[0].t2D描画(TJAPlayer3.app.Device, -490 - this.ct下背景スクロール用タイマー5.n現在の値, -40, new Rectangle(0, 696, 1409, 739));
                        for (int l = 1; l < ForLoop2 + 1; l++)
                        {
                            TJAPlayer3.Tx.Background_DownC[0].t2D描画(TJAPlayer3.app.Device, -490 + (l * 980) - this.ct下背景スクロール用タイマー5.n現在の値, -40, new Rectangle(0, 696, 1409, 739));
                        }
                        //もろもろ
                        TJAPlayer3.Tx.Background_DownC[0].t2D中心基準描画(TJAPlayer3.app.Device, 960, 750 - c, new Rectangle(0, 1510, 1922, 665));
                        TJAPlayer3.Tx.Background_DownC[0].t2D中心基準描画(TJAPlayer3.app.Device, 960, 750 + (c * 2), new Rectangle(1922, 2188, 2034, 944));
                        TJAPlayer3.Tx.Background_DownC[0].t2D中心基準描画(TJAPlayer3.app.Device, 1400, 300 + (c * 5/2), new Rectangle(707, 0, 877, 623));
                        TJAPlayer3.Tx.Background_DownC[0].t2D中心基準描画(TJAPlayer3.app.Device, 460, 760 + (c * 5 / 2), new Rectangle(1584, 0, 897, 623));
                        TJAPlayer3.Tx.Background_DownC[0].t2D描画(TJAPlayer3.app.Device, -490 - this.ct下背景スクロール用タイマー4.n現在の値, 830, new Rectangle(0, 0, 707, 362));
                        for (int l = 1; l < ForLoop1 + 1; l++)
                        {
                            TJAPlayer3.Tx.Background_DownC[0].t2D描画(TJAPlayer3.app.Device, -490 + (l * 490) - this.ct下背景スクロール用タイマー4.n現在の値, 830, new Rectangle(0, 0, 707, 362));
                        }
                    }
                }
                #endregion
            }

            return base.On進行描画();
        }

        #region[ private ]
        //-----------------
        private CCounter[] ct上背景スクロール用タイマー;
        private CCounter[] 上下;
        private CCounter ct下背景スクロール用タイマー1;
        private CCounter ct下背景スクロール用タイマー2;
        private CCounter ct下背景スクロール用タイマー3;
        private CCounter ct下背景スクロール用タイマー4;
        private CCounter ct下背景スクロール用タイマー5;
        private CCounter p;
        public CCounter ct;
        public bool U;
        private CCounter ct上背景FIFOタイマー;
        private CCounter[] ct上背景クリアインタイマー;
        public Random random = new Random();
        //-----------------
        #endregion
    }
}
　
