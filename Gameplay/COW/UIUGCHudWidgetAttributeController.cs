using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200240A")]
public abstract class UIUGCHudWidgetAttributeController<T> : UIUGCHudWidgetAttributeBaseController
{
	[Token(Token = "0x400E096")]
	[FieldOffset(Offset = "0x0")]
	protected T m_AttributeData;

	[Token(Token = "0x400E097")]
	[FieldOffset(Offset = "0x0")]
	protected Action<T> m_GetAction;

	[Token(Token = "0x170010F7")]
	public abstract T AttributeData
	{
		[Token(Token = "0x600CBAB")]
		get;
		[Token(Token = "0x600CBAC")]
		set;
	}

	[Token(Token = "0x170010F8")]
	public override object AttributeObject
	{
		[Token(Token = "0x600CBB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600CBB1")]
		set
		{
		}
	}

	[Token(Token = "0x600CBAA")]
	protected UIUGCHudWidgetAttributeController()
	{
	}

	[Token(Token = "0x600CBAD")]
	public void BindAttribute(T initValue, Action<T> get)
	{
	}

	[Token(Token = "0x600CBAE")]
	public override void SetAttributeDirty()
	{
	}

	[Token(Token = "0x600CBAF")]
	public virtual void InitAttribute(T data)
	{
	}
}
