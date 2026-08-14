using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028CC")]
public class UIHudWereWolvesSpeakerController : UIBaseController, _Attribute
{
	[Token(Token = "0x400FAFC")]
	[FieldOffset(Offset = "0x28")]
	private UIHudWereWolvesVoteSpeakerView m_View;

	[Token(Token = "0x400FAFD")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudWereWolvesVoteController m_parent;

	[Token(Token = "0x400FAFE")]
	[FieldOffset(Offset = "0x30")]
	private List<IHAAMHPPLMG> m_PlayerList;

	[Token(Token = "0x400FAFF")]
	[FieldOffset(Offset = "0x0")]
	private static Func<HDCFACOPKDC, bool> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x601013A")]
	[Address(RVA = "0x256CF64", Offset = "0x256CF64", VA = "0x256CF64")]
	public UIHudWereWolvesSpeakerController()
	{
	}

	[Token(Token = "0x601013B")]
	[Address(RVA = "0x256D01C", Offset = "0x256D01C", VA = "0x256D01C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601013C")]
	[Address(RVA = "0x256D0C4", Offset = "0x256D0C4", VA = "0x256D0C4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601013D")]
	[Address(RVA = "0x256D3D4", Offset = "0x256D3D4", VA = "0x256D3D4")]
	public void SetData(UIHudWereWolvesVoteController parent)
	{
	}

	[Token(Token = "0x601013E")]
	[Address(RVA = "0x256DA0C", Offset = "0x256DA0C", VA = "0x256DA0C")]
	private int Cmp(HDCFACOPKDC infoA, HDCFACOPKDC infoB)
	{
		return default(int);
	}

	[Token(Token = "0x601013F")]
	[Address(RVA = "0x256DAD0", Offset = "0x256DAD0", VA = "0x256DAD0", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010140")]
	[Address(RVA = "0x256DC00", Offset = "0x256DC00", VA = "0x256DC00", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6010141")]
	[Address(RVA = "0x256DC7C", Offset = "0x256DC7C", VA = "0x256DC7C")]
	private void OnAllClick()
	{
	}

	[Token(Token = "0x6010142")]
	[Address(RVA = "0x256E598", Offset = "0x256E598", VA = "0x256E598")]
	private void OnBgClick()
	{
	}

	[Token(Token = "0x6010143")]
	[Address(RVA = "0x256E77C", Offset = "0x256E77C", VA = "0x256E77C")]
	private static bool _003CSetData_003Em__0(HDCFACOPKDC voteInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6010144")]
	[Address(RVA = "0x256E894", Offset = "0x256E894", VA = "0x256E894")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
