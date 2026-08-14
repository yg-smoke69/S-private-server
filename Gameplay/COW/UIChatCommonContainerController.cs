using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200250A")]
public class UIChatCommonContainerController : UIChatBaseContainerController
{
	[Token(Token = "0x400E5EC")]
	[FieldOffset(Offset = "0x28")]
	private UIChatCommonContainerView m_View;

	[Token(Token = "0x600D6C4")]
	[Address(RVA = "0x262E1AC", Offset = "0x262E1AC", VA = "0x262E1AC")]
	public UIChatCommonContainerController()
	{
	}

	[Token(Token = "0x600D6C5")]
	[Address(RVA = "0x262E1B0", Offset = "0x262E1B0", VA = "0x262E1B0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D6C6")]
	[Address(RVA = "0x262E254", Offset = "0x262E254", VA = "0x262E254", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D6C7")]
	[Address(RVA = "0x262E310", Offset = "0x262E310", VA = "0x262E310", Slot = "31")]
	public override GameObject GetContentNode()
	{
		return null;
	}

	[Token(Token = "0x600D6C8")]
	[Address(RVA = "0x262E380", Offset = "0x262E380", VA = "0x262E380", Slot = "32")]
	public override GameObject GetEmptyNode()
	{
		return null;
	}

	[Token(Token = "0x600D6C9")]
	[Address(RVA = "0x262E3F0", Offset = "0x262E3F0", VA = "0x262E3F0", Slot = "33")]
	public override UIScrollView GetMessageList()
	{
		return null;
	}

	[Token(Token = "0x600D6CA")]
	[Address(RVA = "0x262E460", Offset = "0x262E460", VA = "0x262E460", Slot = "35")]
	public override void RefreshContentNode()
	{
	}

	[Token(Token = "0x600D6CB")]
	[Address(RVA = "0x262E4B4", Offset = "0x262E4B4", VA = "0x262E4B4", Slot = "34")]
	public override void InitWidget(Transform parent)
	{
	}

	[Token(Token = "0x600D6CC")]
	[Address(RVA = "0x262E598", Offset = "0x262E598", VA = "0x262E598")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D6CD")]
	[Address(RVA = "0x262E5A0", Offset = "0x262E5A0", VA = "0x262E5A0")]
	public void _003C_003EiFixBaseProxy_InitWidget(Transform P0)
	{
	}
}
