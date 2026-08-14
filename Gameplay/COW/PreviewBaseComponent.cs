using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C72")]
public class PreviewBaseComponent : MonoBehaviour
{
	[Token(Token = "0x4010FA4")]
	[FieldOffset(Offset = "0xC")]
	protected FrontEndPreviewComponent m_FrontEndPreviewComponent;

	[Token(Token = "0x601287A")]
	[Address(RVA = "0x1C18894", Offset = "0x1C18894", VA = "0x1C18894")]
	public PreviewBaseComponent()
	{
	}

	[Token(Token = "0x601287B")]
	[Address(RVA = "0x1C1889C", Offset = "0x1C1889C", VA = "0x1C1889C", Slot = "4")]
	public virtual void SetFrontEndPreviewComponent(FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}
}
