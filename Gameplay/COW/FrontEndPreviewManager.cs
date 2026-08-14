using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C71")]
public class FrontEndPreviewManager : SingletonModule<FrontEndPreviewManager>
{
	[Token(Token = "0x4010FA3")]
	[FieldOffset(Offset = "0xC")]
	private List<FrontEndPreviewComponent> m_FrontEndPreviewComponents;

	[Token(Token = "0x17001330")]
	public FrontEndPreviewComponent CurrentFrontEndPreviewComponent
	{
		[Token(Token = "0x6012873")]
		[Address(RVA = "0x104E0B8", Offset = "0x104E0B8", VA = "0x104E0B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6012872")]
	[Address(RVA = "0x104DFF4", Offset = "0x104DFF4", VA = "0x104DFF4")]
	public FrontEndPreviewManager()
	{
	}

	[Token(Token = "0x6012874")]
	[Address(RVA = "0x104E2AC", Offset = "0x104E2AC", VA = "0x104E2AC", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6012875")]
	[Address(RVA = "0x104E374", Offset = "0x104E374", VA = "0x104E374", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6012876")]
	[Address(RVA = "0x104E5AC", Offset = "0x104E5AC", VA = "0x104E5AC")]
	public void AddFrontEndPreviewComponent(FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	[Token(Token = "0x6012877")]
	[Address(RVA = "0x104E678", Offset = "0x104E678", VA = "0x104E678")]
	public void RemoveFrontEndPreviewComponent(FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	[Token(Token = "0x6012878")]
	[Address(RVA = "0x104E3D4", Offset = "0x104E3D4", VA = "0x104E3D4")]
	public void CloseAllPreview()
	{
	}

	[Token(Token = "0x6012879")]
	[Address(RVA = "0x104E744", Offset = "0x104E744", VA = "0x104E744")]
	public void ClearResourceRefCache()
	{
	}
}
