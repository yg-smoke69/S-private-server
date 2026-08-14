using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022E6")]
internal class UIHUDRushingPetsJumpController : UIHudButtonBaseController
{
	[Token(Token = "0x400D9E0")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudRushingPetsJumpView m_View;

	[Token(Token = "0x400D9E1")]
	[FieldOffset(Offset = "0x30")]
	private bool m_Isfalling;

	[Token(Token = "0x400D9E2")]
	private const string m_JumpIconName = "FF_UI_RushingPets_Jump";

	[Token(Token = "0x400D9E3")]
	private const string m_JumpIconFallingName = "FF_UI_RushingPets_Jump01";

	[Token(Token = "0x600C033")]
	[Address(RVA = "0x1688658", Offset = "0x1688658", VA = "0x1688658")]
	public UIHUDRushingPetsJumpController()
	{
	}

	[Token(Token = "0x600C034")]
	[Address(RVA = "0x1688660", Offset = "0x1688660", VA = "0x1688660")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C035")]
	[Address(RVA = "0x1688744", Offset = "0x1688744", VA = "0x1688744", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600C036")]
	[Address(RVA = "0x16887E8", Offset = "0x16887E8", VA = "0x16887E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C037")]
	[Address(RVA = "0x16888C8", Offset = "0x16888C8", VA = "0x16888C8")]
	private void Update()
	{
	}

	[Token(Token = "0x600C038")]
	[Address(RVA = "0x1688A00", Offset = "0x1688A00", VA = "0x1688A00")]
	private void SetHightlight(bool flag)
	{
	}

	[Token(Token = "0x600C039")]
	[Address(RVA = "0x1688B4C", Offset = "0x1688B4C", VA = "0x1688B4C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
