using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001FB8")]
internal class UIAwakenstoryItemController : UIBaseController
{
	[Token(Token = "0x2001FB9")]
	private sealed class _003CStartShowComic_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C6FD")]
		[FieldOffset(Offset = "0x8")]
		internal UIAwakenstoryItemController _0024this;

		[Token(Token = "0x400C6FE")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400C6FF")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400C700")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17000FA6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009EA0")]
			[Address(RVA = "0x1401C74", Offset = "0x1401C74", VA = "0x1401C74", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FA7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009EA1")]
			[Address(RVA = "0x1401C7C", Offset = "0x1401C7C", VA = "0x1401C7C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009E9E")]
		[Address(RVA = "0x14015C0", Offset = "0x14015C0", VA = "0x14015C0")]
		public _003CStartShowComic_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6009E9F")]
		[Address(RVA = "0x1401984", Offset = "0x1401984", VA = "0x1401984", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009EA2")]
		[Address(RVA = "0x1401C84", Offset = "0x1401C84", VA = "0x1401C84", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009EA3")]
		[Address(RVA = "0x1401C98", Offset = "0x1401C98", VA = "0x1401C98", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001FBA")]
	private sealed class _003CPlayAndWaitingForAnimationOver_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C701")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CaniamtionTime_003E__0;

		[Token(Token = "0x400C702")]
		[FieldOffset(Offset = "0xC")]
		internal Animation animationCom;

		[Token(Token = "0x400C703")]
		[FieldOffset(Offset = "0x10")]
		internal string animation;

		[Token(Token = "0x400C704")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400C705")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400C706")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x17000FA8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009EA6")]
			[Address(RVA = "0x14018D8", Offset = "0x14018D8", VA = "0x14018D8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FA9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009EA7")]
			[Address(RVA = "0x14018E0", Offset = "0x14018E0", VA = "0x14018E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009EA4")]
		[Address(RVA = "0x14016CC", Offset = "0x14016CC", VA = "0x14016CC")]
		public _003CPlayAndWaitingForAnimationOver_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x6009EA5")]
		[Address(RVA = "0x14016E4", Offset = "0x14016E4", VA = "0x14016E4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009EA8")]
		[Address(RVA = "0x14018E8", Offset = "0x14018E8", VA = "0x14018E8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009EA9")]
		[Address(RVA = "0x14018FC", Offset = "0x14018FC", VA = "0x14018FC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C6F8")]
	[FieldOffset(Offset = "0x28")]
	private AvatarAwakenComicData m_Data;

	[Token(Token = "0x400C6F9")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_StoryId;

	[Token(Token = "0x400C6FA")]
	[FieldOffset(Offset = "0x30")]
	private UIAwakenStoryItemView m_View;

	[Token(Token = "0x400C6FB")]
	[FieldOffset(Offset = "0x34")]
	private UIPanel m_Conatainer;

	[Token(Token = "0x400C6FC")]
	[FieldOffset(Offset = "0x38")]
	private int m_DefaultDepth;

	[Token(Token = "0x6009E92")]
	[Address(RVA = "0x1400D9C", Offset = "0x1400D9C", VA = "0x1400D9C")]
	public UIAwakenstoryItemController()
	{
	}

	[Token(Token = "0x6009E93")]
	[Address(RVA = "0x1400E20", Offset = "0x1400E20", VA = "0x1400E20", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009E94")]
	[Address(RVA = "0x1400F90", Offset = "0x1400F90", VA = "0x1400F90", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6009E95")]
	[Address(RVA = "0x140101C", Offset = "0x140101C", VA = "0x140101C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009E96")]
	[Address(RVA = "0x14010C4", Offset = "0x14010C4", VA = "0x14010C4")]
	public void SetContainer(UIPanel panel)
	{
	}

	[Token(Token = "0x6009E97")]
	[Address(RVA = "0x1401148", Offset = "0x1401148", VA = "0x1401148")]
	public void SetCDNInfo(AvatarAwakenComicData comicData)
	{
	}

	[Token(Token = "0x6009E98")]
	[Address(RVA = "0x1401484", Offset = "0x1401484", VA = "0x1401484")]
	private void OnPlayButtonClick()
	{
	}

	[Token(Token = "0x6009E99")]
	[Address(RVA = "0x14014F4", Offset = "0x14014F4", VA = "0x14014F4")]
	private IEnumerator StartShowComic()
	{
		return null;
	}

	[Token(Token = "0x6009E9A")]
	[Address(RVA = "0x14013DC", Offset = "0x14013DC", VA = "0x14013DC")]
	private void SetCDN(UINetworkTextureExt cdn, string url)
	{
	}

	[Token(Token = "0x6009E9B")]
	[Address(RVA = "0x14015C8", Offset = "0x14015C8", VA = "0x14015C8")]
	private IEnumerator PlayAndWaitingForAnimationOver(Animation animationCom, string animation)
	{
		return null;
	}

	[Token(Token = "0x6009E9C")]
	[Address(RVA = "0x14016D4", Offset = "0x14016D4", VA = "0x14016D4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009E9D")]
	[Address(RVA = "0x14016DC", Offset = "0x14016DC", VA = "0x14016DC")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
