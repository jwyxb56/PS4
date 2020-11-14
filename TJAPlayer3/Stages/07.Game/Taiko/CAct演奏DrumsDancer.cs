using FDK;
using System.Drawing;
using System;

namespace TJAPlayer3
{
    internal class CAct演奏DrumsDancer : CActivity
    {
        /// <summary>
        /// 踊り子
        /// </summary>
        public CAct演奏DrumsDancer()
        {
            base.b活性化してない = true;
        }

        public override void On活性化()
        {
            this.ct踊り子モーション = new CCounter();
            base.On活性化();
        }

        public override void On非活性化()
        {
            this.ct踊り子モーション = null;
            base.On非活性化();
        }

        public override void OnManagedリソースの作成()
        {
            n =random.Next(1, 6);
            this.ar踊り子モーション番号 = C変換.ar配列形式のstringをint配列に変換して返す(TJAPlayer3.Skin.Game_Dancer_Motion);
            if(this.ar踊り子モーション番号 == null) ar踊り子モーション番号 = C変換.ar配列形式のstringをint配列に変換して返す("0,0");
            this.ct踊り子モーション = new CCounter(0, this.ar踊り子モーション番号.Length - 1, 0.01, CSound管理.rc演奏用タイマ);
            this.モーションナンバー = new CCounter(0, TJAPlayer3.Skin.Game_Dancer_PtnA, TJAPlayer3.Skin.Game_Dancer_Speed, TJAPlayer3.Timer);
            base.OnManagedリソースの作成();
        }

        public override int On進行描画()
        {
            if( this.b初めての進行描画 )
            {
                this.b初めての進行描画 = false;
            }

            if (this.ct踊り子モーション != null || TJAPlayer3.Skin.Game_Dancer_Ptn != 0) this.ct踊り子モーション.t進行LoopDb();

            if (TJAPlayer3.ConfigIni.ShowDancer && this.ct踊り子モーション != null && TJAPlayer3.Skin.Game_Dancer_Ptn != 0)
            {
                for (int i = 0; i < TJAPlayer3.Tx.Dancer.Length; i++)
                {
                    if (TJAPlayer3.Tx.Dancer[i][this.ar踊り子モーション番号[(int)this.ct踊り子モーション.db現在の値]] != null)
                    {
                        if ((int)TJAPlayer3.stage演奏ドラム画面.actGauge.db現在のゲージ値[0] >= TJAPlayer3.Skin.Game_Dancer_Gauge[i])
                            TJAPlayer3.Tx.Dancer[i][this.ar踊り子モーション番号[(int)this.ct踊り子モーション.db現在の値]].t2D中心基準描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Game_Dancer_X[i], TJAPlayer3.Skin.Game_Dancer_Y[i]);
                    }
                }
            }
            if (TJAPlayer3.ConfigIni.ShowDancer && this.モーションナンバー != null) this.モーションナンバー.t進行Loop();
            {
                for (int i = 0; i < 5; i++)
                {
                    if ((int)TJAPlayer3.stage演奏ドラム画面.actGauge.db現在のゲージ値[0] >= TJAPlayer3.Skin.Game_Dancer_Gauge[i])
                    {
                        TJAPlayer3.Tx.D[this.ar踊り子モーション番号[(int)this.モーションナンバー.db現在の値]].t2D中心基準描画(TJAPlayer3.app.Device, TJAPlayer3.Skin.Game_Dancer_X[i], TJAPlayer3.Skin.Game_Dancer_Y[i], new Rectangle(406 * (this.モーションナンバー.n現在の値), 406 * n, 406, 406));
                    }
                }
            }

                return base.On進行描画();
        }

        #region[ private ]
        //-----------------
        public int[] ar踊り子モーション番号;
        public CCounter ct踊り子モーション;
        public CCounter モーションナンバー;
        int n;
        public Random random = new Random();
        //-----------------
        #endregion
    }
}
