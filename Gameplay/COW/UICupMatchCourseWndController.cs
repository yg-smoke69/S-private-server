using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002068")]
public class UICupMatchCourseWndController : UIPopupWindowController
{
	[Token(Token = "0x2002069")]
	private sealed class _003CAnimationEventHandler_003Ec__AnonStorey0
	{
		[Token(Token = "0x400CB39")]
		[FieldOffset(Offset = "0x8")]
		internal float delayTime;

		[Token(Token = "0x400CB3A")]
		[FieldOffset(Offset = "0xC")]
		internal UICupMatchCourseWndController _0024this;

		[Token(Token = "0x600A624")]
		[Address(RVA = "0x274EF8C", Offset = "0x274EF8C", VA = "0x274EF8C")]
		public _003CAnimationEventHandler_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600A625")]
		[Address(RVA = "0x274F064", Offset = "0x274F064", VA = "0x274F064")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x600A626")]
		[Address(RVA = "0x274F090", Offset = "0x274F090", VA = "0x274F090")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x400CB34")]
	[FieldOffset(Offset = "0x48")]
	private UICupMatchCourseWndView m_View;

	[Token(Token = "0x400CB35")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_CloseDelayCall;

	[Token(Token = "0x400CB36")]
	[FieldOffset(Offset = "0x50")]
	private uint m_CountDownDelayCall;

	[Token(Token = "0x400CB37")]
	[FieldOffset(Offset = "0x54")]
	private UICupMatchCourseAnimController m_Ctrl;

	[Token(Token = "0x400CB38")]
	[FieldOffset(Offset = "0x58")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x600A617")]
	[Address(RVA = "0x274E12C", Offset = "0x274E12C", VA = "0x274E12C")]
	public UICupMatchCourseWndController()
	{
	}

	[Token(Token = "0x600A618")]
	[Address(RVA = "0x274E134", Offset = "0x274E134", VA = "0x274E134")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A619")]
	[Address(RVA = "0x274E1DC", Offset = "0x274E1DC", VA = "0x274E1DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A61A")]
	[Address(RVA = "0x274E62C", Offset = "0x274E62C", VA = "0x274E62C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A61B")]
	[Address(RVA = "0x274E7E4", Offset = "0x274E7E4", VA = "0x274E7E4")]
	public void SetData(int key)
	{
	}

	[Token(Token = "0x600A61C")]
	[Address(RVA = "0x274EA44", Offset = "0x274EA44", VA = "0x274EA44")]
	private void AnimationEventHandler(object[] data)
	{
	}

	[Token(Token = "0x600A61D")]
	[Address(RVA = "0x274E49C", Offset = "0x274E49C", VA = "0x274E49C")]
	private void HideAllUI()
	{
	}

	[Token(Token = "0x600A61E")]
	[Address(RVA = "0x274EF94", Offset = "0x274EF94", VA = "0x274EF94", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600A61F")]
	[Address(RVA = "0x274EFEC", Offset = "0x274EFEC", VA = "0x274EFEC", Slot = "40")]
	public override bool ClosedByEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x600A620")]
	[Address(RVA = "0x274F044", Offset = "0x274F044", VA = "0x274F044")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A621")]
	[Address(RVA = "0x274F04C", Offset = "0x274F04C", VA = "0x274F04C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600A622")]
	[Address(RVA = "0x274F054", Offset = "0x274F054", VA = "0x274F054")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600A623")]
	[Address(RVA = "0x274F05C", Offset = "0x274F05C", VA = "0x274F05C")]
	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return default(bool);
	}
}
