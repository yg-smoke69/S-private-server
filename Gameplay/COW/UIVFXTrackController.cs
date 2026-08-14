using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002BF8")]
internal class UIVFXTrackController : UIBaseController
{
	[Token(Token = "0x4010CA2")]
	[FieldOffset(Offset = "0x28")]
	private UIVFXTrackView m_View;

	[Token(Token = "0x4010CA3")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DestroyDelay;

	[Token(Token = "0x4010CA4")]
	[FieldOffset(Offset = "0x30")]
	private bool m_DestroyAfterTrackEnd;

	[Token(Token = "0x4010CA5")]
	[FieldOffset(Offset = "0x34")]
	private int m_MyIndex;

	[Token(Token = "0x4010CA6")]
	[FieldOffset(Offset = "0x0")]
	private static int m_Index;

	[Token(Token = "0x17001315")]
	private static int IndexGenerator
	{
		[Token(Token = "0x60123DD")]
		[Address(RVA = "0x2844080", Offset = "0x2844080", VA = "0x2844080")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60123DB")]
	[Address(RVA = "0x2843F54", Offset = "0x2843F54", VA = "0x2843F54")]
	public UIVFXTrackController()
	{
	}

	[Token(Token = "0x60123DC")]
	[Address(RVA = "0x2843FD8", Offset = "0x2843FD8", VA = "0x2843FD8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60123DE")]
	[Address(RVA = "0x2844170", Offset = "0x2844170", VA = "0x2844170", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60123DF")]
	[Address(RVA = "0x28442AC", Offset = "0x28442AC", VA = "0x28442AC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x60123E0")]
	[Address(RVA = "0x28443B4", Offset = "0x28443B4", VA = "0x28443B4")]
	public void PlayVFX(Vector3 startPos, Vector3 endPos, bool destroyAfterTrackEnd = true)
	{
	}

	[Token(Token = "0x60123E1")]
	[Address(RVA = "0x2844640", Offset = "0x2844640", VA = "0x2844640")]
	private void OnTrackEnd(object[] datas)
	{
	}

	[Token(Token = "0x60123E3")]
	[Address(RVA = "0x28448E4", Offset = "0x28448E4", VA = "0x28448E4")]
	private void _003COnTrackEnd_003Em__0()
	{
	}

	[Token(Token = "0x60123E4")]
	[Address(RVA = "0x2844908", Offset = "0x2844908", VA = "0x2844908")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60123E5")]
	[Address(RVA = "0x2844910", Offset = "0x2844910", VA = "0x2844910")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
