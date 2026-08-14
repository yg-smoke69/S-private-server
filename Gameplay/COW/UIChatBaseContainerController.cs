using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002506")]
public abstract class UIChatBaseContainerController : UIBaseController
{
	[Token(Token = "0x600D69D")]
	[Address(RVA = "0x262B3E8", Offset = "0x262B3E8", VA = "0x262B3E8")]
	protected UIChatBaseContainerController()
	{
	}

	[Token(Token = "0x600D69E")]
	public abstract GameObject GetContentNode();

	[Token(Token = "0x600D69F")]
	public abstract GameObject GetEmptyNode();

	[Token(Token = "0x600D6A0")]
	public abstract UIScrollView GetMessageList();

	[Token(Token = "0x600D6A1")]
	[Address(RVA = "0x262B46C", Offset = "0x262B46C", VA = "0x262B46C", Slot = "34")]
	public virtual void InitWidget(Transform parent)
	{
	}

	[Token(Token = "0x600D6A2")]
	public abstract void RefreshContentNode();
}
