using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002894")]
internal class UIHUDUGC_AddScoreVFXController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002895")]
	private sealed class _003CShowVfxArc_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F9ED")]
		[FieldOffset(Offset = "0x8")]
		internal UIHUDUGC_AddScoreVFXController _0024this;

		[Token(Token = "0x400F9EE")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400F9EF")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400F9F0")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170011FD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600FED3")]
			[Address(RVA = "0x2224624", Offset = "0x2224624", VA = "0x2224624", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011FE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600FED4")]
			[Address(RVA = "0x222462C", Offset = "0x222462C", VA = "0x222462C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600FED1")]
		[Address(RVA = "0x222428C", Offset = "0x222428C", VA = "0x222428C")]
		public _003CShowVfxArc_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600FED2")]
		[Address(RVA = "0x2224490", Offset = "0x2224490", VA = "0x2224490", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600FED5")]
		[Address(RVA = "0x2224634", Offset = "0x2224634", VA = "0x2224634", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600FED6")]
		[Address(RVA = "0x2224648", Offset = "0x2224648", VA = "0x2224648", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002896")]
	private sealed class _003CHideScores_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F9F1")]
		[FieldOffset(Offset = "0x8")]
		internal UIHUDUGC_AddScoreVFXController _0024this;

		[Token(Token = "0x400F9F2")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400F9F3")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400F9F4")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170011FF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600FED9")]
			[Address(RVA = "0x22243E4", Offset = "0x22243E4", VA = "0x22243E4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001200")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600FEDA")]
			[Address(RVA = "0x22243EC", Offset = "0x22243EC", VA = "0x22243EC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600FED7")]
		[Address(RVA = "0x2224294", Offset = "0x2224294", VA = "0x2224294")]
		public _003CHideScores_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600FED8")]
		[Address(RVA = "0x22242A4", Offset = "0x22242A4", VA = "0x22242A4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600FEDB")]
		[Address(RVA = "0x22243F4", Offset = "0x22243F4", VA = "0x22243F4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600FEDC")]
		[Address(RVA = "0x2224408", Offset = "0x2224408", VA = "0x2224408", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400F9E9")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_AddScoreVFXView m_View;

	[Token(Token = "0x400F9EA")]
	[FieldOffset(Offset = "0x2C")]
	private AddScoreVFXHudEntity m_ViewData;

	[Token(Token = "0x400F9EB")]
	[FieldOffset(Offset = "0x30")]
	private string m_EntityID;

	[Token(Token = "0x400F9EC")]
	[FieldOffset(Offset = "0x34")]
	private GameObject m_VFX;

	[Token(Token = "0x600FEC7")]
	[Address(RVA = "0x22235D8", Offset = "0x22235D8", VA = "0x22235D8")]
	public UIHUDUGC_AddScoreVFXController()
	{
	}

	[Token(Token = "0x600FEC8")]
	[Address(RVA = "0x222365C", Offset = "0x222365C", VA = "0x222365C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FEC9")]
	[Address(RVA = "0x2223704", Offset = "0x2223704", VA = "0x2223704", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FECA")]
	[Address(RVA = "0x22237C0", Offset = "0x22237C0", VA = "0x22237C0", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600FECB")]
	[Address(RVA = "0x222393C", Offset = "0x222393C", VA = "0x222393C", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600FECC")]
	[Address(RVA = "0x2223A94", Offset = "0x2223A94", VA = "0x2223A94")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600FECD")]
	[Address(RVA = "0x2223B34", Offset = "0x2223B34", VA = "0x2223B34")]
	private void OnScoreNumChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600FECE")]
	[Address(RVA = "0x22240F4", Offset = "0x22240F4", VA = "0x22240F4")]
	private IEnumerator ShowVfxArc()
	{
		return null;
	}

	[Token(Token = "0x600FECF")]
	[Address(RVA = "0x22241C0", Offset = "0x22241C0", VA = "0x22241C0")]
	private IEnumerator HideScores()
	{
		return null;
	}

	[Token(Token = "0x600FED0")]
	[Address(RVA = "0x222429C", Offset = "0x222429C", VA = "0x222429C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
