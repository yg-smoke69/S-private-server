using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200206D")]
public class UICupMatchFactionController : UIPopupWindowController
{
	[Token(Token = "0x200206E")]
	private sealed class _003CAnimationEventHandler_003Ec__AnonStorey0
	{
		[Token(Token = "0x400CB62")]
		[FieldOffset(Offset = "0x8")]
		internal float delayTime;

		[Token(Token = "0x400CB63")]
		[FieldOffset(Offset = "0xC")]
		internal UICupMatchFactionController _0024this;

		[Token(Token = "0x600A654")]
		[Address(RVA = "0x2AA2BD0", Offset = "0x2AA2BD0", VA = "0x2AA2BD0")]
		public _003CAnimationEventHandler_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600A655")]
		[Address(RVA = "0x2AA2CA8", Offset = "0x2AA2CA8", VA = "0x2AA2CA8")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x600A656")]
		[Address(RVA = "0x2AA2CD4", Offset = "0x2AA2CD4", VA = "0x2AA2CD4")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x400CB5C")]
	[FieldOffset(Offset = "0x48")]
	public UICupMatchFactionView m_View;

	[Token(Token = "0x400CB5D")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CB5E")]
	[FieldOffset(Offset = "0x50")]
	private uint m_CloseDelayCall;

	[Token(Token = "0x400CB5F")]
	[FieldOffset(Offset = "0x54")]
	private uint m_CountDownDelayCall;

	[Token(Token = "0x400CB60")]
	[FieldOffset(Offset = "0x58")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CB61")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_SetDataReady;

	[Token(Token = "0x600A647")]
	[Address(RVA = "0x2AA1A54", Offset = "0x2AA1A54", VA = "0x2AA1A54")]
	public UICupMatchFactionController()
	{
	}

	[Token(Token = "0x600A648")]
	[Address(RVA = "0x2AA1A5C", Offset = "0x2AA1A5C", VA = "0x2AA1A5C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A649")]
	[Address(RVA = "0x2AA1B04", Offset = "0x2AA1B04", VA = "0x2AA1B04", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A64A")]
	[Address(RVA = "0x2AA1ED0", Offset = "0x2AA1ED0", VA = "0x2AA1ED0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A64B")]
	[Address(RVA = "0x2AA2088", Offset = "0x2AA2088", VA = "0x2AA2088")]
	public void SetData(int key)
	{
	}

	[Token(Token = "0x600A64C")]
	[Address(RVA = "0x2AA2514", Offset = "0x2AA2514", VA = "0x2AA2514")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600A64D")]
	[Address(RVA = "0x2AA2688", Offset = "0x2AA2688", VA = "0x2AA2688")]
	private void AnimationEventHandler(object[] data)
	{
	}

	[Token(Token = "0x600A64E")]
	[Address(RVA = "0x2AA2BD8", Offset = "0x2AA2BD8", VA = "0x2AA2BD8", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600A64F")]
	[Address(RVA = "0x2AA2C30", Offset = "0x2AA2C30", VA = "0x2AA2C30", Slot = "40")]
	public override bool ClosedByEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x600A650")]
	[Address(RVA = "0x2AA2C88", Offset = "0x2AA2C88", VA = "0x2AA2C88")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A651")]
	[Address(RVA = "0x2AA2C90", Offset = "0x2AA2C90", VA = "0x2AA2C90")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600A652")]
	[Address(RVA = "0x2AA2C98", Offset = "0x2AA2C98", VA = "0x2AA2C98")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600A653")]
	[Address(RVA = "0x2AA2CA0", Offset = "0x2AA2CA0", VA = "0x2AA2CA0")]
	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return default(bool);
	}
}
