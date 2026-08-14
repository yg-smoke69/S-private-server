using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002BE7")]
internal class UIVeteranReturnController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x2002BE8")]
	private sealed class _003CBRSetFX_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010C59")]
		[FieldOffset(Offset = "0x8")]
		internal int brFirstIndex;

		[Token(Token = "0x4010C5A")]
		[FieldOffset(Offset = "0xC")]
		internal UIVeteranReturnController _0024this;

		[Token(Token = "0x6012340")]
		[Address(RVA = "0x2CB8210", Offset = "0x2CB8210", VA = "0x2CB8210")]
		public _003CBRSetFX_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6012341")]
		[Address(RVA = "0x2CBAABC", Offset = "0x2CBAABC", VA = "0x2CBAABC")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002BE9")]
	private sealed class _003CBRSetFX_003Ec__AnonStorey1
	{
		[Token(Token = "0x4010C5B")]
		[FieldOffset(Offset = "0x8")]
		internal int brNotFirstIndex;

		[Token(Token = "0x4010C5C")]
		[FieldOffset(Offset = "0xC")]
		internal UIVeteranReturnController _0024this;

		[Token(Token = "0x6012342")]
		[Address(RVA = "0x2CB8218", Offset = "0x2CB8218", VA = "0x2CB8218")]
		public _003CBRSetFX_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6012343")]
		[Address(RVA = "0x2CBACA8", Offset = "0x2CBACA8", VA = "0x2CBACA8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002BEA")]
	private sealed class _003CCSSetFX_003Ec__AnonStorey2
	{
		[Token(Token = "0x4010C5D")]
		[FieldOffset(Offset = "0x8")]
		internal int csFirstIndex;

		[Token(Token = "0x4010C5E")]
		[FieldOffset(Offset = "0xC")]
		internal UIVeteranReturnController _0024this;

		[Token(Token = "0x6012344")]
		[Address(RVA = "0x2CB8794", Offset = "0x2CB8794", VA = "0x2CB8794")]
		public _003CCSSetFX_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6012345")]
		[Address(RVA = "0x2CBAE94", Offset = "0x2CBAE94", VA = "0x2CBAE94")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002BEB")]
	private sealed class _003CCSSetFX_003Ec__AnonStorey3
	{
		[Token(Token = "0x4010C5F")]
		[FieldOffset(Offset = "0x8")]
		internal int csNotFirstIndex;

		[Token(Token = "0x4010C60")]
		[FieldOffset(Offset = "0xC")]
		internal UIVeteranReturnController _0024this;

		[Token(Token = "0x6012346")]
		[Address(RVA = "0x2CB879C", Offset = "0x2CB879C", VA = "0x2CB879C")]
		public _003CCSSetFX_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6012347")]
		[Address(RVA = "0x2CBB080", Offset = "0x2CBB080", VA = "0x2CBB080")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4010C37")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string[] m_ReturnContentArray;

	[Token(Token = "0x4010C38")]
	[FieldOffset(Offset = "0x48")]
	private UIVeteranReturnView m_View;

	[Token(Token = "0x4010C39")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelUser m_ModelUser;

	[Token(Token = "0x4010C3A")]
	[FieldOffset(Offset = "0x50")]
	private UIModelProfile m_ModelProfile;

	[Token(Token = "0x4010C3B")]
	[FieldOffset(Offset = "0x54")]
	private UIModelCSLadderMatch m_CsLaddermodel;

	[Token(Token = "0x4010C3C")]
	[FieldOffset(Offset = "0x58")]
	private UIModelVeteranSignin m_ModelVeteran;

	[Token(Token = "0x4010C3D")]
	[FieldOffset(Offset = "0x5C")]
	private uint brlifetime;

	[Token(Token = "0x4010C3E")]
	[FieldOffset(Offset = "0x60")]
	private uint brKillTimes;

	[Token(Token = "0x4010C3F")]
	[FieldOffset(Offset = "0x64")]
	private uint brMostKillsInMatch;

	[Token(Token = "0x4010C40")]
	[FieldOffset(Offset = "0x68")]
	private uint brRevives;

	[Token(Token = "0x4010C41")]
	[FieldOffset(Offset = "0x70")]
	private long brSurvivalTimes;

	[Token(Token = "0x4010C42")]
	[FieldOffset(Offset = "0x78")]
	private List<bool> flagList;

	[Token(Token = "0x4010C43")]
	[FieldOffset(Offset = "0x7C")]
	private List<GameObject> labelIsShow;

	[Token(Token = "0x4010C44")]
	[FieldOffset(Offset = "0x80")]
	private List<Animation> brItem;

	[Token(Token = "0x4010C45")]
	[FieldOffset(Offset = "0x84")]
	private List<Animation> csItem;

	[Token(Token = "0x4010C46")]
	[FieldOffset(Offset = "0x88")]
	private List<bool> brIsShow;

	[Token(Token = "0x4010C47")]
	[FieldOffset(Offset = "0x8C")]
	private List<bool> csIsShow;

	[Token(Token = "0x4010C48")]
	[FieldOffset(Offset = "0x90")]
	private List<bool> gunIsShow;

	[Token(Token = "0x4010C49")]
	private const int BRLABELNUM = 5;

	[Token(Token = "0x4010C4A")]
	private const int CSLABELNUM = 7;

	[Token(Token = "0x4010C4B")]
	private const int TOTALLABELLNUM = 4;

	[Token(Token = "0x4010C4C")]
	[FieldOffset(Offset = "0x94")]
	private int bri;

	[Token(Token = "0x4010C4D")]
	[FieldOffset(Offset = "0x98")]
	private int csi;

	[Token(Token = "0x4010C4E")]
	[FieldOffset(Offset = "0x9C")]
	private List<uint> m_LabelDelaycallCSList;

	[Token(Token = "0x4010C4F")]
	[FieldOffset(Offset = "0xA0")]
	private List<uint> m_LabelDelaycallBRList;

	[Token(Token = "0x4010C50")]
	[FieldOffset(Offset = "0xA4")]
	private List<uint> m_LabelDelaycallGunsList;

	[Token(Token = "0x4010C51")]
	[FieldOffset(Offset = "0xA8")]
	private List<uint> m_SetBtnStateTimeList;

	[Token(Token = "0x4010C52")]
	[FieldOffset(Offset = "0xAC")]
	private uint m_LabelDelaycallEnd;

	[Token(Token = "0x4010C53")]
	[FieldOffset(Offset = "0xB0")]
	private uint m_LabelDelaycallNext;

	[Token(Token = "0x4010C54")]
	[FieldOffset(Offset = "0xB4")]
	private int m_BrShowNum;

	[Token(Token = "0x4010C55")]
	[FieldOffset(Offset = "0xB8")]
	private int m_CsShowNum;

	[Token(Token = "0x4010C56")]
	[FieldOffset(Offset = "0xBC")]
	private int m_AllReady;

	[Token(Token = "0x4010C57")]
	[FieldOffset(Offset = "0xC0")]
	private int m_FlagFirst;

	[Token(Token = "0x4010C58")]
	[FieldOffset(Offset = "0xC4")]
	private AudioResource m_audioType;

	[Token(Token = "0x601231B")]
	[Address(RVA = "0x2CAF3E8", Offset = "0x2CAF3E8", VA = "0x2CAF3E8")]
	public UIVeteranReturnController()
	{
	}

	[Token(Token = "0x601231C")]
	[Address(RVA = "0x2CAF5B8", Offset = "0x2CAF5B8", VA = "0x2CAF5B8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601231D")]
	[Address(RVA = "0x2CAF65C", Offset = "0x2CAF65C", VA = "0x2CAF65C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601231E")]
	[Address(RVA = "0x2CAFFA0", Offset = "0x2CAFFA0", VA = "0x2CAFFA0")]
	private void RefreshAwakeFeelingReturn()
	{
	}

	[Token(Token = "0x601231F")]
	[Address(RVA = "0x2CB3B30", Offset = "0x2CB3B30", VA = "0x2CB3B30")]
	private void ShowAwakeFeelingReturn()
	{
	}

	[Token(Token = "0x6012320")]
	[Address(RVA = "0x2CB408C", Offset = "0x2CB408C", VA = "0x2CB408C")]
	private void BRPerformanceReviewIsShow(uint type)
	{
	}

	[Token(Token = "0x6012321")]
	[Address(RVA = "0x2CB5880", Offset = "0x2CB5880", VA = "0x2CB5880")]
	private void CSPerformanceReviewIsShow()
	{
	}

	[Token(Token = "0x6012322")]
	[Address(RVA = "0x2CB022C", Offset = "0x2CB022C", VA = "0x2CB022C")]
	private void RegularShowNew()
	{
	}

	[Token(Token = "0x6012323")]
	[Address(RVA = "0x2CB3A80", Offset = "0x2CB3A80", VA = "0x2CB3A80")]
	private int TimeStampDay(ulong timespan1, ulong timespan2)
	{
		return default(int);
	}

	[Token(Token = "0x6012324")]
	[Address(RVA = "0x2CB3F94", Offset = "0x2CB3F94", VA = "0x2CB3F94")]
	private string TimeStampYear(ulong timespan1, ulong timespan2)
	{
		return null;
	}

	[Token(Token = "0x6012325")]
	[Address(RVA = "0x2CB73A8", Offset = "0x2CB73A8", VA = "0x2CB73A8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6012326")]
	[Address(RVA = "0x2CB7C38", Offset = "0x2CB7C38", VA = "0x2CB7C38", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6012327")]
	[Address(RVA = "0x2CB7C9C", Offset = "0x2CB7C9C", VA = "0x2CB7C9C")]
	private void BRSetFX()
	{
	}

	[Token(Token = "0x6012328")]
	[Address(RVA = "0x2CB8220", Offset = "0x2CB8220", VA = "0x2CB8220")]
	private void CSSetFX()
	{
	}

	[Token(Token = "0x6012329")]
	[Address(RVA = "0x2CB87A4", Offset = "0x2CB87A4", VA = "0x2CB87A4")]
	private void GunsSetFX()
	{
	}

	[Token(Token = "0x601232A")]
	[Address(RVA = "0x2CB8EA4", Offset = "0x2CB8EA4", VA = "0x2CB8EA4")]
	private void OnNextBtnClick()
	{
	}

	[Token(Token = "0x601232B")]
	[Address(RVA = "0x2CB94D0", Offset = "0x2CB94D0", VA = "0x2CB94D0")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x601232C")]
	[Address(RVA = "0x2CB977C", Offset = "0x2CB977C", VA = "0x2CB977C", Slot = "40")]
	public override bool ClosedByEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x601232D")]
	[Address(RVA = "0x2CB97D4", Offset = "0x2CB97D4", VA = "0x2CB97D4")]
	private void OnStartDateFinished()
	{
	}

	[Token(Token = "0x601232E")]
	[Address(RVA = "0x2CB9954", Offset = "0x2CB9954", VA = "0x2CB9954")]
	private void OnLandOnLabelFinished()
	{
	}

	[Token(Token = "0x601232F")]
	[Address(RVA = "0x2CB9A04", Offset = "0x2CB9A04", VA = "0x2CB9A04")]
	private void OnPlayTimeLabelFinished()
	{
	}

	[Token(Token = "0x6012330")]
	[Address(RVA = "0x2CB9B84", Offset = "0x2CB9B84", VA = "0x2CB9B84", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6012331")]
	[Address(RVA = "0x2CB9D4C", Offset = "0x2CB9D4C", VA = "0x2CB9D4C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6012333")]
	[Address(RVA = "0x2CBA40C", Offset = "0x2CBA40C", VA = "0x2CBA40C")]
	private void _003CBRSetFX_003Em__0()
	{
	}

	[Token(Token = "0x6012334")]
	[Address(RVA = "0x2CBA450", Offset = "0x2CBA450", VA = "0x2CBA450")]
	private void _003CCSSetFX_003Em__1()
	{
	}

	[Token(Token = "0x6012335")]
	[Address(RVA = "0x2CBA494", Offset = "0x2CBA494", VA = "0x2CBA494")]
	private void _003CGunsSetFX_003Em__2()
	{
	}

	[Token(Token = "0x6012336")]
	[Address(RVA = "0x2CBA5BC", Offset = "0x2CBA5BC", VA = "0x2CBA5BC")]
	private void _003CGunsSetFX_003Em__3()
	{
	}

	[Token(Token = "0x6012337")]
	[Address(RVA = "0x2CBA6E4", Offset = "0x2CBA6E4", VA = "0x2CBA6E4")]
	private void _003CGunsSetFX_003Em__4()
	{
	}

	[Token(Token = "0x6012338")]
	[Address(RVA = "0x2CBA80C", Offset = "0x2CBA80C", VA = "0x2CBA80C")]
	private void _003CGunsSetFX_003Em__5()
	{
	}

	[Token(Token = "0x6012339")]
	[Address(RVA = "0x2CBA934", Offset = "0x2CBA934", VA = "0x2CBA934")]
	private void _003CGunsSetFX_003Em__6()
	{
	}

	[Token(Token = "0x601233A")]
	[Address(RVA = "0x2CBA9B4", Offset = "0x2CBA9B4", VA = "0x2CBA9B4")]
	private void _003COnNextBtnClick_003Em__7()
	{
	}

	[Token(Token = "0x601233B")]
	[Address(RVA = "0x2CBAA94", Offset = "0x2CBAA94", VA = "0x2CBAA94")]
	private void _003COnCloseBtnClick_003Em__8()
	{
	}

	[Token(Token = "0x601233C")]
	[Address(RVA = "0x2CBAA9C", Offset = "0x2CBAA9C", VA = "0x2CBAA9C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601233D")]
	[Address(RVA = "0x2CBAAA4", Offset = "0x2CBAAA4", VA = "0x2CBAAA4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x601233E")]
	[Address(RVA = "0x2CBAAAC", Offset = "0x2CBAAAC", VA = "0x2CBAAAC")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x601233F")]
	[Address(RVA = "0x2CBAAB4", Offset = "0x2CBAAB4", VA = "0x2CBAAB4")]
	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return default(bool);
	}
}
