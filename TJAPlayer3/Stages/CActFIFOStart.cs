using FDK;
using System;
using System.Drawing;

namespace TJAPlayer3
{
	internal class CActFIFOStart : CActivity
	{
		// メソッド

		public void tフェードアウト開始()
		{
			this.mode = EFIFOモード.フェードアウト;

            this.counter = new CCounter( 0, 500, 4, TJAPlayer3.Timer );
			SetStartFadeOutTextureOpaque();
		}
		public void tフェードイン開始()
		{
			this.mode = EFIFOモード.フェードイン;
			this.counter = new CCounter( 0, 1500, 4, TJAPlayer3.Timer );
			SetStartFadeOutTextureOpaque();
		}
		private static void SetStartFadeOutTextureOpaque()
		{
			var frameBoxIndex = CStrジャンルtoNum.ForFrameBoxIndex(TJAPlayer3.stage選曲.r現在選択中の曲.strジャンル);
			var txResultFadeIn = TJAPlayer3.Tx.SongLoading_FadeOut;
			if (txResultFadeIn != null)
			{
				txResultFadeIn[frameBoxIndex].Opacity = 255;
			}
		}
		// CActivity 実装

		public override void On非活性化()
		{
			if( !base.b活性化してない )
			{
                //CDTXMania.tテクスチャの解放( ref this.tx幕 );
				base.On非活性化();
			}
		}
		public override void OnManagedリソースの作成()
		{
			this.counter1 = new CCounter(0, 100, 6, TJAPlayer3.Timer);
			if ( !base.b活性化してない )
			{
				this.counter2 = new CCounter(0, 100, 10, TJAPlayer3.Timer);
				//this.tx幕 = CDTXMania.tテクスチャの生成( CSkin.Path( @"Graphics\6_FO.png" ) );
				//	this.tx幕2 = CDTXMania.tテクスチャの生成( CSkin.Path( @"Graphics\6_FI.png" ) );
				base.OnManagedリソースの作成();
			}
		}
		public override int On進行描画()
		{
			if( base.b活性化してない || ( this.counter == null ) )
			{
				return 0;
			}
			if (base.b活性化してない || (this.counter2 == null))
			{
				return 0;
			}
			this.counter.t進行();
			this.counter1.t進行();
			this.counter2.t進行();
			// Size clientSize = CDTXMania.app.Window.ClientSize;	// #23510 2010.10.31 yyagi: delete as of no one use this any longer.
			var frameBoxIndex = CStrジャンルtoNum.ForFrameBoxIndex(TJAPlayer3.stage選曲.r現在選択中の曲.strジャンル);
			if (this.mode == EFIFOモード.フェードアウト)
			{
				if (TJAPlayer3.Tx.SongLoading_FadeOut != null)
				{
					TJAPlayer3.Tx.SongLoading_FadeOut[frameBoxIndex].Opacity = (0 + counter.n現在の値) * 0xff / 100;
					TJAPlayer3.Tx.SongLoading_FadeOut[frameBoxIndex]?.t2D描画(TJAPlayer3.app.Device, 0, 0);
				}

			}
			else
			{
				if (TJAPlayer3.Tx.SongLoading_FadeIn != null)
				{
					TJAPlayer3.Tx.SongLoading_FadeOut[frameBoxIndex].Opacity = (((100 - this.counter.n現在の値) * 0xff) / 100);
					TJAPlayer3.Tx.SongLoading_FadeOut[frameBoxIndex]?.t2D描画(TJAPlayer3.app.Device, 0, 0);
				}
			}

			if ( this.mode == EFIFOモード.フェードアウト )
            {
			    if( this.counter.n現在の値 != 500)
			    {
				    return 0;
			    }
            }
            else if( this.mode == EFIFOモード.フェードイン )
            {
			    if( this.counter.n現在の値 != 1500)
			    {
				    return 0;
			    }
            }
			return 1;
		}


		// その他

		#region [ private ]
		//-----------------
		private CCounter counter;
		private CCounter counter1;
		private CCounter counter2;
		private EFIFOモード mode;
        //private CTexture tx幕;
        //private CTexture tx幕2;
		//-----------------
		#endregion
	}
}
