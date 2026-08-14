using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C43")]
public class UIHudWereWolvesHistroyItemController : UIEasyListItemController
{
	[Token(Token = "0x4010E19")]
	[FieldOffset(Offset = "0x38")]
	private UIHudWereWolvesHistroyItemView m_View;

	[Token(Token = "0x4010E1A")]
	[FieldOffset(Offset = "0x3C")]
	private List<UIHudWereWolvesVoteIndexController> m_IdxChildList;

	[Token(Token = "0x6012761")]
	[Address(RVA = "0x2566E74", Offset = "0x2566E74", VA = "0x2566E74")]
	public UIHudWereWolvesHistroyItemController()
	{
	}

	[Token(Token = "0x6012762")]
	[Address(RVA = "0x2566F00", Offset = "0x2566F00", VA = "0x2566F00")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012763")]
	[Address(RVA = "0x2566FA8", Offset = "0x2566FA8", VA = "0x2566FA8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012764")]
	[Address(RVA = "0x2567064", Offset = "0x2567064", VA = "0x2567064", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6012765")]
	[Address(RVA = "0x2567938", Offset = "0x2567938", VA = "0x2567938")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
