using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002061")]
public class UICupMatchChampionController : UIPopupWindowController
{
	[Token(Token = "0x2002062")]
	private sealed class _003CAnimationEventHandler_003Ec__AnonStorey0
	{
		[Token(Token = "0x400CAFE")]
		[FieldOffset(Offset = "0x8")]
		internal float delayTime;

		[Token(Token = "0x400CAFF")]
		[FieldOffset(Offset = "0xC")]
		internal UICupMatchChampionController _0024this;

		[Token(Token = "0x600A599")]
		[Address(RVA = "0x273DE98", Offset = "0x273DE98", VA = "0x273DE98")]
		public _003CAnimationEventHandler_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600A59A")]
		[Address(RVA = "0x273DF70", Offset = "0x273DF70", VA = "0x273DF70")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x600A59B")]
		[Address(RVA = "0x273DF9C", Offset = "0x273DF9C", VA = "0x273DF9C")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x400CAF9")]
	[FieldOffset(Offset = "0x48")]
	private UICupMatchChampionView m_View;

	[Token(Token = "0x400CAFA")]
	[FieldOffset(Offset = "0x4C")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CAFB")]
	[FieldOffset(Offset = "0x50")]
	private uint m_CloseDelayCall;

	[Token(Token = "0x400CAFC")]
	[FieldOffset(Offset = "0x54")]
	private uint m_CountDownDelayCall;

	[Token(Token = "0x400CAFD")]
	[FieldOffset(Offset = "0x58")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x600A58B")]
	[Address(RVA = "0x273CCE0", Offset = "0x273CCE0", VA = "0x273CCE0")]
	public UICupMatchChampionController()
	{
	}

	[Token(Token = "0x600A58C")]
	[Address(RVA = "0x273CCE8", Offset = "0x273CCE8", VA = "0x273CCE8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A58D")]
	[Address(RVA = "0x273CD90", Offset = "0x273CD90", VA = "0x273CD90", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A58E")]
	[Address(RVA = "0x273D15C", Offset = "0x273D15C", VA = "0x273D15C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A58F")]
	[Address(RVA = "0x273D314", Offset = "0x273D314", VA = "0x273D314")]
	public void SetData(int key)
	{
	}

	[Token(Token = "0x600A590")]
	[Address(RVA = "0x273D424", Offset = "0x273D424", VA = "0x273D424")]
	private void RefreshTeamInfo()
	{
	}

	[Token(Token = "0x600A591")]
	[Address(RVA = "0x273D698", Offset = "0x273D698", VA = "0x273D698")]
	private void RefreshCupMatchIcon()
	{
	}

	[Token(Token = "0x600A592")]
	[Address(RVA = "0x273D950", Offset = "0x273D950", VA = "0x273D950")]
	private void AnimationEventHandler(object[] data)
	{
	}

	[Token(Token = "0x600A593")]
	[Address(RVA = "0x273DEA0", Offset = "0x273DEA0", VA = "0x273DEA0", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600A594")]
	[Address(RVA = "0x273DEF8", Offset = "0x273DEF8", VA = "0x273DEF8", Slot = "40")]
	public override bool ClosedByEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x600A595")]
	[Address(RVA = "0x273DF50", Offset = "0x273DF50", VA = "0x273DF50")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A596")]
	[Address(RVA = "0x273DF58", Offset = "0x273DF58", VA = "0x273DF58")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600A597")]
	[Address(RVA = "0x273DF60", Offset = "0x273DF60", VA = "0x273DF60")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600A598")]
	[Address(RVA = "0x273DF68", Offset = "0x273DF68", VA = "0x273DF68")]
	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return default(bool);
	}
}
