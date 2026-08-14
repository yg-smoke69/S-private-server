using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022C2")]
public class UIPVEGameStartRewardItemController : UIBaseController
{
	[Token(Token = "0x400D943")]
	[FieldOffset(Offset = "0x28")]
	private UIPVEStartGameItemView m_View;

	[Token(Token = "0x400D944")]
	[FieldOffset(Offset = "0x2C")]
	private BaseItemInfo m_Data;

	[Token(Token = "0x600BF4E")]
	[Address(RVA = "0x15A4CB4", Offset = "0x15A4CB4", VA = "0x15A4CB4")]
	public UIPVEGameStartRewardItemController()
	{
	}

	[Token(Token = "0x600BF4F")]
	[Address(RVA = "0x15A4D38", Offset = "0x15A4D38", VA = "0x15A4D38")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BF50")]
	[Address(RVA = "0x15A4DE0", Offset = "0x15A4DE0", VA = "0x15A4DE0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BF51")]
	[Address(RVA = "0x15A41E0", Offset = "0x15A41E0", VA = "0x15A41E0")]
	public void SetViewData(BaseItemInfo data)
	{
	}

	[Token(Token = "0x600BF52")]
	[Address(RVA = "0x15A4240", Offset = "0x15A4240", VA = "0x15A4240")]
	public void RefreshUI()
	{
	}

	[Token(Token = "0x600BF53")]
	[Address(RVA = "0x15A4E9C", Offset = "0x15A4E9C", VA = "0x15A4E9C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
