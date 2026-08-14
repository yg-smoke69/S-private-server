using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C5D")]
internal class FrontEndClickFilter : MonoBehaviour
{
	[Token(Token = "0x2002C5E")]
	private sealed class _003COnAddClickFilter_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010EC7")]
		[FieldOffset(Offset = "0x8")]
		internal object[] data;

		[Token(Token = "0x6012838")]
		[Address(RVA = "0xDF4484", Offset = "0xDF4484", VA = "0xDF4484")]
		public _003COnAddClickFilter_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6012839")]
		[Address(RVA = "0xDF4E1C", Offset = "0xDF4E1C", VA = "0xDF4E1C")]
		internal bool _003C_003Em__0(ClickFilterData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002C5F")]
	private sealed class _003COnRemovelickFilter_003Ec__AnonStorey1
	{
		[Token(Token = "0x4010EC8")]
		[FieldOffset(Offset = "0x8")]
		internal string key;

		[Token(Token = "0x601283A")]
		[Address(RVA = "0xDF46C4", Offset = "0xDF46C4", VA = "0xDF46C4")]
		public _003COnRemovelickFilter_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601283B")]
		[Address(RVA = "0xDF500C", Offset = "0xDF500C", VA = "0xDF500C")]
		internal bool _003C_003Em__0(ClickFilterData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4010EC4")]
	[FieldOffset(Offset = "0xC")]
	public ClickFilterData[] FilterArr;

	[Token(Token = "0x4010EC5")]
	[FieldOffset(Offset = "0x10")]
	private List<ClickFilterData> m_Filters;

	[Token(Token = "0x4010EC6")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<string, Rect> m_DictRect;

	[Token(Token = "0x601282F")]
	[Address(RVA = "0xDF34A0", Offset = "0xDF34A0", VA = "0xDF34A0")]
	public FrontEndClickFilter()
	{
	}

	[Token(Token = "0x6012830")]
	[Address(RVA = "0xDF3560", Offset = "0xDF3560", VA = "0xDF3560")]
	private void Start()
	{
	}

	[Token(Token = "0x6012831")]
	[Address(RVA = "0xDF3D00", Offset = "0xDF3D00", VA = "0xDF3D00")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6012832")]
	[Address(RVA = "0xDF3AF4", Offset = "0xDF3AF4", VA = "0xDF3AF4")]
	private void RegisterUICameraCustomInput(OnCustomInput handler)
	{
	}

	[Token(Token = "0x6012833")]
	[Address(RVA = "0xDF3ED4", Offset = "0xDF3ED4", VA = "0xDF3ED4")]
	private void UnRegisterUICameraCustomInput(OnCustomInput handler)
	{
	}

	[Token(Token = "0x6012834")]
	[Address(RVA = "0xDF40E0", Offset = "0xDF40E0", VA = "0xDF40E0")]
	private void OnAddClickFilter(object[] data)
	{
	}

	[Token(Token = "0x6012835")]
	[Address(RVA = "0xDF448C", Offset = "0xDF448C", VA = "0xDF448C")]
	private void OnRemovelickFilter(object[] data)
	{
	}

	[Token(Token = "0x6012836")]
	[Address(RVA = "0xDF46CC", Offset = "0xDF46CC", VA = "0xDF46CC")]
	private void OnUICameraCustomInput()
	{
	}

	[Token(Token = "0x6012837")]
	[Address(RVA = "0xDF3864", Offset = "0xDF3864", VA = "0xDF3864")]
	private void AddRect(ClickFilterData fd)
	{
	}
}
