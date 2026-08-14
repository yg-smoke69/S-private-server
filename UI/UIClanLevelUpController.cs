using COW;
using GCommon;
using Il2CppDummyDll;
using proto;

[Token(Token = "0x2002548")]
public class UIClanLevelUpController : UIPopupWindowController
{
	[Token(Token = "0x400E706")]
	[FieldOffset(Offset = "0x48")]
	private UIClanLevelUpViewExt m_View;

	[Token(Token = "0x600D907")]
	[Address(RVA = "0x1468FDC", Offset = "0x1468FDC", VA = "0x1468FDC")]
	public UIClanLevelUpController()
	{
	}

	[Token(Token = "0x600D908")]
	[Address(RVA = "0x1468FE4", Offset = "0x1468FE4", VA = "0x1468FE4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D909")]
	[Address(RVA = "0x1469048", Offset = "0x1469048", VA = "0x1469048", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D90A")]
	[Address(RVA = "0x146915C", Offset = "0x146915C", VA = "0x146915C")]
	public void SetLevelData(uint before, uint after, AwardData awardList)
	{
	}

	[Token(Token = "0x600D90B")]
	[Address(RVA = "0x1469504", Offset = "0x1469504", VA = "0x1469504")]
	private void OnOKClick()
	{
	}
}
