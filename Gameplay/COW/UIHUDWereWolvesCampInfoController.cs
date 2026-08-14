using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C3F")]
public class UIHUDWereWolvesCampInfoController : UIBaseController
{
	[Token(Token = "0x4010DF7")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDWereWolvesCampInfoView m_View;

	[Token(Token = "0x4010DF8")]
	[FieldOffset(Offset = "0x2C")]
	private KeyHelperWereWolvesCampHUD m_KeyHelper;

	[Token(Token = "0x4010DF9")]
	[FieldOffset(Offset = "0x30")]
	private float m_EndTime;

	[Token(Token = "0x4010DFA")]
	[FieldOffset(Offset = "0x34")]
	private float m_TotalTime;

	[Token(Token = "0x4010DFB")]
	[FieldOffset(Offset = "0x38")]
	private int lastLeftTimeS;

	[Token(Token = "0x6012726")]
	[Address(RVA = "0x2935090", Offset = "0x2935090", VA = "0x2935090")]
	public UIHUDWereWolvesCampInfoController()
	{
	}

	[Token(Token = "0x6012727")]
	[Address(RVA = "0x293511C", Offset = "0x293511C", VA = "0x293511C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012728")]
	[Address(RVA = "0x29351C4", Offset = "0x29351C4", VA = "0x29351C4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012729")]
	[Address(RVA = "0x293539C", Offset = "0x293539C", VA = "0x293539C")]
	public void ShowData(bool isWolf, int wolfCount, List<byte> teammateWolfsColorIndex, float endTime, bool isPredictToolOwner)
	{
	}

	[Token(Token = "0x601272A")]
	[Address(RVA = "0x2935B58", Offset = "0x2935B58", VA = "0x2935B58")]
	private void SetWolfTeamateInfo(List<byte> teammateWolfsColorIndex)
	{
	}

	[Token(Token = "0x601272B")]
	[Address(RVA = "0x2935F54", Offset = "0x2935F54", VA = "0x2935F54")]
	private void Update()
	{
	}

	[Token(Token = "0x601272C")]
	[Address(RVA = "0x29356D4", Offset = "0x29356D4", VA = "0x29356D4")]
	private void UpdateLeftTimeShow()
	{
	}

	[Token(Token = "0x601272D")]
	[Address(RVA = "0x2935FB4", Offset = "0x2935FB4", VA = "0x2935FB4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
