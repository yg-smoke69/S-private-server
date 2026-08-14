using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CCA")]
public abstract class UIFrontEndPreviewUIComponentTemplateBaseController<T> : UIFrontEndPreviewUIComponentBaseController where T : UIFrontEndPreviewUIComponentBaseView
{
	[Token(Token = "0x4011163")]
	[FieldOffset(Offset = "0x0")]
	protected T m_View;

	[Token(Token = "0x6012BF7")]
	protected UIFrontEndPreviewUIComponentTemplateBaseController()
	{
	}

	[Token(Token = "0x6012BF8")]
	public T GetView()
	{
		return null;
	}

	[Token(Token = "0x6012BF9")]
	protected abstract T InitBaseView();

	[Token(Token = "0x6012BFA")]
	protected override void OnUIInit()
	{
	}
}
