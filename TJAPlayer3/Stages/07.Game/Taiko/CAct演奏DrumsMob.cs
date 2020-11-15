﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using FDK;

namespace TJAPlayer3
{
    internal class CAct演奏DrumsMob : CActivity
    {
        /// <summary>
        /// 踊り子
        /// </summary>
        public CAct演奏DrumsMob()
        {
            base.b活性化してない = true;
        }

        public override void On活性化()
        {
            ctMob = new CCounter();
            ctMobPtn = new CCounter();
            base.On活性化();
        }

        public override void On非活性化()
        {
            ctMob = null;
            ctMobPtn = null;
            base.On非活性化();
        }

        public override void OnManagedリソースの作成()
        {
            base.OnManagedリソースの作成();
        }

        public override void OnManagedリソースの解放()
        {
            base.OnManagedリソースの解放();
        }

        public override int On進行描画()
        {
            if(!TJAPlayer3.stage演奏ドラム画面.bDoublePlay)
            {
                if (ctMob != null || TJAPlayer3.Skin.Game_Mob_Ptn != 0) ctMob.t進行LoopDb();
                if (ctMobPtn != null || TJAPlayer3.Skin.Game_Mob_Ptn != 0) ctMobPtn.t進行LoopDb();

                //CDTXMania.act文字コンソール.tPrint(0, 0, C文字コンソール.Eフォント種別.白, ctMob.db現在の値.ToString());
                //CDTXMania.act文字コンソール.tPrint(0, 10, C文字コンソール.Eフォント種別.白, Math.Sin((float)this.ctMob.db現在の値 * (Math.PI / 180)).ToString());

                if(TJAPlayer3.Skin.Game_Mob_Ptn != 0 && TJAPlayer3.ConfigIni.eGaugeMode != EGaugeMode.Hard && TJAPlayer3.ConfigIni.eGaugeMode != EGaugeMode.ExHard)
                {
                    //下MOB
                    if (TJAPlayer3.stage演奏ドラム画面.actGauge.db現在のゲージ値[0] >= 100)
                    {
                        TJAPlayer3.Tx.Mob[(int)ctMobPtn.db現在の値]?.t2D描画(TJAPlayer3.app.Device, 0, (1375 - (TJAPlayer3.Tx.Mob[0].szテクスチャサイズ.Height - 105)) + -((float)Math.Sin((float)this.ctMob.db現在の値 * (Math.PI / 180)) * 105));
                    }
                    //上MOB
                    if (TJAPlayer3.stage演奏ドラム画面.actGauge.db現在のゲージ値[0] >= 100)
                    {
                        TJAPlayer3.Tx.Mob1[0].t2D範囲描画(TJAPlayer3.app.Device, 0, (270 - (396 - 115)) + -((float)Math.Sin((float)this.ctMob.db現在の値 * (Math.PI / 180)) * 85), new Rectangle(0, 343, 1920, 396));
                        TJAPlayer3.Tx.Mob1[0].t2D範囲描画(TJAPlayer3.app.Device, 0, (250 - (343 - 105)) + -((float)Math.Sin((float)this.ctMob.db現在の値 * (Math.PI / 180)) * 115), new Rectangle(0, 0, 1920, 343));
                    }

                }
            }
            return base.On進行描画();
        }
        #region[ private ]
        //-----------------
        public CCounter ctMob;
        public CCounter ctMobPtn;
        //-----------------
        #endregion
    }
}
