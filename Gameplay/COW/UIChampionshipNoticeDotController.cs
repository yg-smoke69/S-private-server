using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002012")]
internal class UIChampionshipNoticeDotController : UIBaseController
{
	[Token(Token = "0x400C979")]
	[FieldOffset(Offset = "0x28")]
	private UIChampionshipNoticeDotView m_View;

	[Token(Token = "0x400C97A")]
	[FieldOffset(Offset = "0x2C")]
	public int DotIndex;

	[Token(Token = "0x600A24E")]
	[Address(RVA = "0x28348D0", Offset = "0x28348D0", VA = "0x28348D0")]
	public UIChampionshipNoticeDotController()
	{
	}

	[Token(Token = "0x600A24F")]
	[Address(RVA = "0x2834954", Offset = "0x2834954", VA = "0x2834954")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A250")]
	[Address(RVA = "0x28349FC", Offset = "0x28349FC", VA = "0x28349FC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A251")]
	[Address(RVA = "0x2834024", Offset = "0x2834024", VA = "0x2834024")]
	public void SetSelected(bool v)
	{
	}

	[Token(Token = "0x600A252")]
	[Address(RVA = "0x2834B28", Offset = "0x2834B28", VA = "0x2834B28")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
