using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002BF7")]
internal class UIVeteranVersionIntroductionController : UIPopupWindowController
{
	[Token(Token = "0x4010C94")]
	[FieldOffset(Offset = "0x48")]
	private UIVeteranVersionIntroductionView m_View;

	[Token(Token = "0x4010C95")]
	[FieldOffset(Offset = "0x4C")]
	private List<GameObject> isLabelShow;

	[Token(Token = "0x4010C96")]
	[FieldOffset(Offset = "0x50")]
	private List<bool> isLabelShowFlag;

	[Token(Token = "0x4010C97")]
	[FieldOffset(Offset = "0x54")]
	private BatchShowContentDesc m_VideoDesc;

	[Token(Token = "0x4010C98")]
	[FieldOffset(Offset = "0x58")]
	private BatchShowContentDesc m_PicDesc;

	[Token(Token = "0x4010C99")]
	[FieldOffset(Offset = "0x5C")]
	private BatchShowContentDesc m_LabelDesc;

	[Token(Token = "0x4010C9A")]
	[FieldOffset(Offset = "0x60")]
	private UIModelVeteranSignin m_ModelVeteran;

	[Token(Token = "0x4010C9B")]
	[FieldOffset(Offset = "0x64")]
	private List<BatchShowContentDesc> m_ActvityIsOn;

	[Token(Token = "0x4010C9C")]
	[FieldOffset(Offset = "0x68")]
	private List<BatchShowContentDesc> m_ModeIsOn;

	[Token(Token = "0x4010C9D")]
	[FieldOffset(Offset = "0x6C")]
	private List<BatchShowContentDesc> m_rewardList;

	[Token(Token = "0x4010C9E")]
	[FieldOffset(Offset = "0x70")]
	private List<uint> m_LabelDelayCallList;

	[Token(Token = "0x4010C9F")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<BatchShowContentDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4010CA0")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<BatchShowContentDesc> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4010CA1")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<BatchShowContentDesc> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x60123B7")]
	[Address(RVA = "0x2CCB204", Offset = "0x2CCB204", VA = "0x2CCB204")]
	public UIVeteranVersionIntroductionController()
	{
	}

	[Token(Token = "0x60123B8")]
	[Address(RVA = "0x2CCB35C", Offset = "0x2CCB35C", VA = "0x2CCB35C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60123B9")]
	[Address(RVA = "0x2CCB400", Offset = "0x2CCB400", VA = "0x2CCB400", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60123BA")]
	[Address(RVA = "0x2CCB9D4", Offset = "0x2CCB9D4", VA = "0x2CCB9D4")]
	private void SetActiveState()
	{
	}

	[Token(Token = "0x60123BB")]
	[Address(RVA = "0x2CCBBC4", Offset = "0x2CCBBC4", VA = "0x2CCBBC4")]
	private void PlayAnimation()
	{
	}

	[Token(Token = "0x60123BC")]
	[Address(RVA = "0x2CCBD28", Offset = "0x2CCBD28", VA = "0x2CCBD28")]
	private void ContentShow()
	{
	}

	[Token(Token = "0x60123BD")]
	[Address(RVA = "0x2CCC8C8", Offset = "0x2CCC8C8", VA = "0x2CCC8C8")]
	private void rePaint()
	{
	}

	[Token(Token = "0x60123BE")]
	[Address(RVA = "0x2CCCA5C", Offset = "0x2CCCA5C", VA = "0x2CCCA5C")]
	private void LabelSetFX()
	{
	}

	[Token(Token = "0x60123BF")]
	[Address(RVA = "0x2CCD0C0", Offset = "0x2CCD0C0", VA = "0x2CCD0C0", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x60123C0")]
	[Address(RVA = "0x2CCD124", Offset = "0x2CCD124", VA = "0x2CCD124", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60123C1")]
	[Address(RVA = "0x2CCD188", Offset = "0x2CCD188", VA = "0x2CCD188", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x60123C2")]
	[Address(RVA = "0x2CCD3C4", Offset = "0x2CCD3C4", VA = "0x2CCD3C4")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x60123C3")]
	[Address(RVA = "0x2CCD6C4", Offset = "0x2CCD6C4", VA = "0x2CCD6C4")]
	private void OnBigEventGoto1Click()
	{
	}

	[Token(Token = "0x60123C4")]
	[Address(RVA = "0x2CCDA18", Offset = "0x2CCDA18", VA = "0x2CCDA18")]
	private void OnBigEventGoto2Click()
	{
	}

	[Token(Token = "0x60123C5")]
	[Address(RVA = "0x2CCDD6C", Offset = "0x2CCDD6C", VA = "0x2CCDD6C")]
	private void OnNewModeGoto1Click()
	{
	}

	[Token(Token = "0x60123C6")]
	[Address(RVA = "0x2CCE0D4", Offset = "0x2CCE0D4", VA = "0x2CCE0D4")]
	private void OnNewModeGoto2Click()
	{
	}

	[Token(Token = "0x60123C7")]
	[Address(RVA = "0x2CCE43C", Offset = "0x2CCE43C", VA = "0x2CCE43C")]
	private void OnVersionFirearmsGotoClick()
	{
	}

	[Token(Token = "0x60123C8")]
	[Address(RVA = "0x2CCE77C", Offset = "0x2CCE77C", VA = "0x2CCE77C")]
	private void OnVideoBtnClick()
	{
	}

	[Token(Token = "0x60123C9")]
	[Address(RVA = "0x2CCECC0", Offset = "0x2CCECC0", VA = "0x2CCECC0")]
	private void OnPicBtnClick()
	{
	}

	[Token(Token = "0x60123CA")]
	[Address(RVA = "0x2CCF160", Offset = "0x2CCF160", VA = "0x2CCF160")]
	private void OnLabelBtnClick()
	{
	}

	[Token(Token = "0x60123CB")]
	[Address(RVA = "0x2CCEB38", Offset = "0x2CCEB38", VA = "0x2CCEB38")]
	private void VideoBtnGoto()
	{
	}

	[Token(Token = "0x60123CC")]
	[Address(RVA = "0x2CCEFD8", Offset = "0x2CCEFD8", VA = "0x2CCEFD8")]
	private void PicBtnGoto()
	{
	}

	[Token(Token = "0x60123CD")]
	[Address(RVA = "0x2CCF478", Offset = "0x2CCF478", VA = "0x2CCF478")]
	private void LabelBtnGoto()
	{
	}

	[Token(Token = "0x60123CE")]
	[Address(RVA = "0x2CCF600", Offset = "0x2CCF600", VA = "0x2CCF600")]
	private bool _003CContentShow_003Em__0(BatchShowContentDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x60123CF")]
	[Address(RVA = "0x2CCF7AC", Offset = "0x2CCF7AC", VA = "0x2CCF7AC")]
	private bool _003CContentShow_003Em__1(BatchShowContentDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x60123D0")]
	[Address(RVA = "0x2CCF958", Offset = "0x2CCF958", VA = "0x2CCF958")]
	private static bool _003CContentShow_003Em__2(BatchShowContentDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x60123D1")]
	[Address(RVA = "0x2CCF988", Offset = "0x2CCF988", VA = "0x2CCF988")]
	private static bool _003CContentShow_003Em__3(BatchShowContentDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x60123D2")]
	[Address(RVA = "0x2CCF9B8", Offset = "0x2CCF9B8", VA = "0x2CCF9B8")]
	private static bool _003CContentShow_003Em__4(BatchShowContentDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x60123D3")]
	[Address(RVA = "0x2CCF9E8", Offset = "0x2CCF9E8", VA = "0x2CCF9E8")]
	private void _003CLabelSetFX_003Em__5()
	{
	}

	[Token(Token = "0x60123D4")]
	[Address(RVA = "0x2CCFACC", Offset = "0x2CCFACC", VA = "0x2CCFACC")]
	private void _003CLabelSetFX_003Em__6()
	{
	}

	[Token(Token = "0x60123D5")]
	[Address(RVA = "0x2CCFBB0", Offset = "0x2CCFBB0", VA = "0x2CCFBB0")]
	private void _003CLabelSetFX_003Em__7()
	{
	}

	[Token(Token = "0x60123D6")]
	[Address(RVA = "0x2CCFC94", Offset = "0x2CCFC94", VA = "0x2CCFC94")]
	private void _003CLabelSetFX_003Em__8()
	{
	}

	[Token(Token = "0x60123D7")]
	[Address(RVA = "0x2CCFD78", Offset = "0x2CCFD78", VA = "0x2CCFD78")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60123D8")]
	[Address(RVA = "0x2CCFD80", Offset = "0x2CCFD80", VA = "0x2CCFD80")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x60123D9")]
	[Address(RVA = "0x2CCFD88", Offset = "0x2CCFD88", VA = "0x2CCFD88")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x60123DA")]
	[Address(RVA = "0x2CCFD90", Offset = "0x2CCFD90", VA = "0x2CCFD90")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
