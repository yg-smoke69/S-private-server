using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B4A")]
internal class UISPHudResultShowController : UIHudResultShowBaseController
{
	[Token(Token = "0x4010982")]
	[FieldOffset(Offset = "0x70")]
	private UISPHudResultShowView m_View;

	[Token(Token = "0x6011D2B")]
	[Address(RVA = "0x1D2BCE8", Offset = "0x1D2BCE8", VA = "0x1D2BCE8")]
	public UISPHudResultShowController()
	{
	}

	[Token(Token = "0x6011D2C")]
	[Address(RVA = "0x1D2BCF0", Offset = "0x1D2BCF0", VA = "0x1D2BCF0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011D2D")]
	[Address(RVA = "0x1D2BD98", Offset = "0x1D2BD98", VA = "0x1D2BD98", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011D2E")]
	[Address(RVA = "0x1D2C654", Offset = "0x1D2C654", VA = "0x1D2C654", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011D2F")]
	[Address(RVA = "0x1D2C23C", Offset = "0x1D2C23C", VA = "0x1D2C23C")]
	private void DoCreateResultShowWindow()
	{
	}

	[Token(Token = "0x6011D30")]
	[Address(RVA = "0x1D2CF70", Offset = "0x1D2CF70", VA = "0x1D2CF70", Slot = "38")]
	public override void CreateProfileCallSign(AvatarProfileInfo data, int index)
	{
	}

	[Token(Token = "0x6011D31")]
	[Address(RVA = "0x1D2D2DC", Offset = "0x1D2D2DC", VA = "0x1D2D2DC")]
	private void BtnMaskTriggered(object[] data)
	{
	}

	[Token(Token = "0x6011D32")]
	[Address(RVA = "0x1D2D344", Offset = "0x1D2D344", VA = "0x1D2D344")]
	private void OnUIClick()
	{
	}

	[Token(Token = "0x6011D33")]
	[Address(RVA = "0x1D2C7F0", Offset = "0x1D2C7F0", VA = "0x1D2C7F0")]
	private void InitTeamView(ResultTeamData teamData)
	{
	}

	[Token(Token = "0x6011D34")]
	[Address(RVA = "0x1D2CC0C", Offset = "0x1D2CC0C", VA = "0x1D2CC0C")]
	private List<PlayerData> SortAndCopyPlayers(List<ResultPlayerData> dataList)
	{
		return null;
	}

	[Token(Token = "0x6011D35")]
	[Address(RVA = "0x1D2D770", Offset = "0x1D2D770", VA = "0x1D2D770")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011D36")]
	[Address(RVA = "0x1D2D778", Offset = "0x1D2D778", VA = "0x1D2D778")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
