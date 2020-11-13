using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using FDK;
namespace TJAPlayer3
{
    internal class CAct演奏Drums演奏終了演出 : CActivity
    {
        /// <summary>
        /// 課題
        /// _クリア失敗 →素材不足(確保はできる。切り出しと加工をしてないだけ。)
        /// _
        /// </summary>
        public CAct演奏Drums演奏終了演出()
        {
            base.b活性化してない = true;
        }

        public void Start()
        {
            this.ct進行メイン = new CCounter(0, 300, 22, TJAPlayer3.Timer);
            // モードの決定。クリア失敗・フルコンボも事前に作っとく。
            if (TJAPlayer3.stage選曲.n確定された曲の難易度 == (int)Difficulty.Dan)
            {
                // 段位認定モード。
                if (!TJAPlayer3.stage演奏ドラム画面.actDan.GetFailedAllChallenges())
                {
                    // 段位認定モード、クリア成功
                    this.Mode[0] = EndMode.StageCleared;
                }
                else
                {
                    // 段位認定モード、クリア失敗
                    this.Mode[0] = EndMode.StageFailed;
                }
            }
            else
            {
                // 通常のモード。
                // ここでフルコンボフラグをチェックするが現時点ではない。
                // 今の段階では魂ゲージ80%以上でチェック。

                //ハードゲージの場合、完奏=クリアなので、
                //EndModeチェックのタイミングでは常にクリアになってもいい気がするけど、一応↓
                for (int i = 0; i < TJAPlayer3.ConfigIni.nPlayerCount; i++)
                {
                    if (TJAPlayer3.ConfigIni.eGaugeMode == EGaugeMode.Hard || TJAPlayer3.ConfigIni.eGaugeMode == EGaugeMode.ExHard)
                    {
                        if (TJAPlayer3.stage演奏ドラム画面.actGauge.db現在のゲージ値[i] > 0)
                            this.Mode[i] = EndMode.StageCleared;
                        else
                            this.Mode[i] = EndMode.StageFailed;
                    }
                    else
                    {
                        if (TJAPlayer3.stage演奏ドラム画面.actGauge.db現在のゲージ値[i] >= 80)
                        {
                            this.Mode[i] = EndMode.StageCleared;
                        }
                        else
                        {
                            this.Mode[i] = EndMode.StageFailed;
                        }
                    }
                    if (TJAPlayer3.stage演奏ドラム画面.nヒット数_Auto含まない.Drums.Miss == 0)
                    {
                        if (TJAPlayer3.stage演奏ドラム画面.nヒット数_Auto含まない.Drums.Great >= 1)
                        {
                            this.Mode[i] = EndMode.StageFullCombo;
                        }
                        else
                        {
                            this.Mode[i] = EndMode.StageDFullCombo;
                        }
                    }
                }
            }
        }

        public override void On活性化()
        {
            this.bリザルトボイス再生済み = false;
            this.Mode = new EndMode[5];
            base.On活性化();
        }

        public override void On非活性化()
        {
            this.ct進行メイン = null;
            this.counter = null;
            this.counter3 = null;
            this.counterf = null;
            base.On非活性化();
        }

        public override void OnManagedリソースの作成()
        {
            this.b再生済み = false;
            this.soundClear = TJAPlayer3.Sound管理.tサウンドを生成する(CSkin.Path(@"Sounds\Clear.ogg"), ESoundGroup.SoundEffect);
            this.counter = new CCounter(0, 300, 70, TJAPlayer3.Timer);
            this.counter2 = new CCounter(0, 50, 30, TJAPlayer3.Timer);
            this.counter3 = new CCounter(0, 100, 50, TJAPlayer3.Timer);
            this.counterf = new CCounter(0, 300, 3, TJAPlayer3.Timer);
            base.OnManagedリソースの作成();
        }

        public override void OnManagedリソースの解放()
        {
            if (this.soundClear != null)
                this.soundClear.t解放する();
            base.OnManagedリソースの解放();
        }

        public override int On進行描画()
        {
            if (base.b初めての進行描画)
            {
                base.b初めての進行描画 = false;
            }
            if (this.ct進行メイン != null && (TJAPlayer3.stage演奏ドラム画面.eフェーズID == CStage.Eフェーズ.演奏_演奏終了演出 || TJAPlayer3.stage演奏ドラム画面.eフェーズID == CStage.Eフェーズ.演奏_STAGE_CLEAR_フェードアウト || TJAPlayer3.stage演奏ドラム画面.eフェーズID == CStage.Eフェーズ.演奏_STAGE_FAILED_ハード))
            {
                this.ct進行メイン.t進行();
                this.counter.t進行();
                this.counter2.t進行();
                this.counter3.t進行();
                this.counterf.t進行Loop();
                //CDTXMania.act文字コンソール.tPrint( 0, 0, C文字コンソール.Eフォント種別.灰, this.ct進行メイン.n現在の値.ToString() );
                //仮置き
                for (int i = 0; i < TJAPlayer3.ConfigIni.nPlayerCount; i++)
                {
                    double 回転値 = 180.0;
                    double b = Math.Sin(this.counter.n現在の値 * Math.PI / (this.counter.n終了値 * 180.0 / 回転値)) * 170;
                    double b1 = Math.Sin(this.counterf.n現在の値 * Math.PI / (this.counterf.n終了値 * 180.0 / 回転値)) * -30;
                    switch (this.Mode[i])
                    {
                        #region [An]
                        case EndMode.StageFailed:
                            #endregion
                            break;
                        #region [C]
                        case EndMode.StageCleared:
                            #endregion
                            break;
                        #region [f]
                        case EndMode.StageFullCombo:
                            #endregion
                            break;
                        case EndMode.StageDFullCombo:
                            break;
                        default:
                            break;
                    }
                
                }



                if (this.ct進行メイン.b終了値に達した)
                {
                    if (!this.bリザルトボイス再生済み)
                    {
                        TJAPlayer3.Skin.sound成績発表.t再生する();
                        this.bリザルトボイス再生済み = true;
                    }
                    return 1;
                }
            }

            return 0;
        }

        #region[ private ]
        //-----------------
        bool b再生済み;
        bool bリザルトボイス再生済み;
        public CCounter counter;
        public CCounter counter2;
        public CCounter counter3;
        public CCounter counterf;
        CCounter ct進行メイン;
        //CTexture[] txバチお左_成功 = new CTexture[ 5 ];
        //CTexture[] txバチお右_成功 = new CTexture[ 5 ];
        //CTexture tx文字;
        //CTexture tx文字マスク;
        CSound soundClear;
        EndMode[] Mode;
        enum EndMode
        {
            StageFailed,
            StageCleared,
            StageFullCombo,
            StageDFullCombo,
        }
        //-----------------
        #endregion
    }
}
