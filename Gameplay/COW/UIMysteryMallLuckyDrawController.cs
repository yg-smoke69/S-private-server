using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20021FC")]
internal class UIMysteryMallLuckyDrawController : UINaviPopController, _Attribute
{
	[Token(Token = "0x20021FD")]
	private sealed class _003CStopDrawCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D4C3")]
		[FieldOffset(Offset = "0x8")]
		internal UIMysteryMallLuckyDrawController _0024this;

		[Token(Token = "0x400D4C4")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400D4C5")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400D4C6")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001037")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600B758")]
			[Address(RVA = "0x1B2B910", Offset = "0x1B2B910", VA = "0x1B2B910", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001038")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B759")]
			[Address(RVA = "0x1B2B918", Offset = "0x1B2B918", VA = "0x1B2B918", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B756")]
		[Address(RVA = "0x1B2B2D8", Offset = "0x1B2B2D8", VA = "0x1B2B2D8")]
		public _003CStopDrawCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600B757")]
		[Address(RVA = "0x1B2B58C", Offset = "0x1B2B58C", VA = "0x1B2B58C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B75A")]
		[Address(RVA = "0x1B2B920", Offset = "0x1B2B920", VA = "0x1B2B920", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600B75B")]
		[Address(RVA = "0x1B2B934", Offset = "0x1B2B934", VA = "0x1B2B934", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D4BF")]
	[FieldOffset(Offset = "0x70")]
	private UIMysteryMallLuckyDrawView m_View;

	[Token(Token = "0x400D4C0")]
	[FieldOffset(Offset = "0x74")]
	private UIModelMysteryMall m_ModelMall;

	[Token(Token = "0x400D4C1")]
	[FieldOffset(Offset = "0x78")]
	private bool m_IsDrawing;

	[Token(Token = "0x400D4C2")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<MysteryShopProbability> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600B742")]
	[Address(RVA = "0x1B27B1C", Offset = "0x1B27B1C", VA = "0x1B27B1C")]
	public UIMysteryMallLuckyDrawController()
	{
	}

	[Token(Token = "0x600B743")]
	[Address(RVA = "0x1B27BA0", Offset = "0x1B27BA0", VA = "0x1B27BA0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B744")]
	[Address(RVA = "0x1B27C48", Offset = "0x1B27C48", VA = "0x1B27C48", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B745")]
	[Address(RVA = "0x1B29390", Offset = "0x1B29390", VA = "0x1B29390", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B746")]
	[Address(RVA = "0x1B29094", Offset = "0x1B29094", VA = "0x1B29094")]
	private void CreateVFXByResID(Transform defaultVFX, ResourceID resId)
	{
	}

	[Token(Token = "0x600B747")]
	[Address(RVA = "0x1B28C18", Offset = "0x1B28C18", VA = "0x1B28C18")]
	private void SetLabelTheme(UILabel label, MysteryMallLuckyDrawThemeData themeData, MysteryMallLuckyDrawThemeData.ECustomLabelType luckyDrawLabel)
	{
	}

	[Token(Token = "0x600B748")]
	[Address(RVA = "0x1B2892C", Offset = "0x1B2892C", VA = "0x1B2892C")]
	private void SetSprite(UISprite sprite, string spriteName)
	{
	}

	[Token(Token = "0x600B749")]
	[Address(RVA = "0x1B294A8", Offset = "0x1B294A8", VA = "0x1B294A8")]
	private void SetLabelColor(UILabel label, Color topColor, Color bottomColor)
	{
	}

	[Token(Token = "0x600B74A")]
	[Address(RVA = "0x1B295D8", Offset = "0x1B295D8", VA = "0x1B295D8")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600B74B")]
	[Address(RVA = "0x1B29C94", Offset = "0x1B29C94", VA = "0x1B29C94")]
	private void ShowDrawingVFX()
	{
	}

	[Token(Token = "0x600B74C")]
	[Address(RVA = "0x1B29F24", Offset = "0x1B29F24", VA = "0x1B29F24")]
	private void ShowProbabilityTips(List<MysteryShopProbability> probabilities)
	{
	}

	[Token(Token = "0x600B74D")]
	[Address(RVA = "0x1B2A720", Offset = "0x1B2A720", VA = "0x1B2A720")]
	private void OnBtnGetLuckClick()
	{
	}

	[Token(Token = "0x600B74E")]
	[Address(RVA = "0x1B2A974", Offset = "0x1B2A974", VA = "0x1B2A974")]
	private void OnBtnGoMysteryClick()
	{
	}

	[Token(Token = "0x600B74F")]
	[Address(RVA = "0x1B2B260", Offset = "0x1B2B260", VA = "0x1B2B260")]
	private void OnBtnProbabilityTipsClick()
	{
	}

	[Token(Token = "0x600B750")]
	[Address(RVA = "0x1B29BC8", Offset = "0x1B29BC8", VA = "0x1B29BC8")]
	private IEnumerator StopDrawCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600B751")]
	[Address(RVA = "0x1B2B2E0", Offset = "0x1B2B2E0", VA = "0x1B2B2E0", Slot = "44")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600B752")]
	[Address(RVA = "0x1B2B374", Offset = "0x1B2B374", VA = "0x1B2B374", Slot = "43")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600B753")]
	[Address(RVA = "0x1B2B53C", Offset = "0x1B2B53C", VA = "0x1B2B53C")]
	private static int _003CShowProbabilityTips_003Em__0(MysteryShopProbability a, MysteryShopProbability b)
	{
		return default(int);
	}

	[Token(Token = "0x600B754")]
	[Address(RVA = "0x1B2B584", Offset = "0x1B2B584", VA = "0x1B2B584")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B755")]
	[Address(RVA = "0x1B2B588", Offset = "0x1B2B588", VA = "0x1B2B588")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
