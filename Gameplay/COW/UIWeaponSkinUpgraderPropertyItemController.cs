using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C17")]
public class UIWeaponSkinUpgraderPropertyItemController : UIBaseController
{
	[Token(Token = "0x2002C18")]
	private sealed class _003CMoveToTargetX_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010D5B")]
		[FieldOffset(Offset = "0x8")]
		internal Vector3 _003Cpos_003E__1;

		[Token(Token = "0x4010D5C")]
		[FieldOffset(Offset = "0x14")]
		internal float targetX;

		[Token(Token = "0x4010D5D")]
		[FieldOffset(Offset = "0x18")]
		internal float _003CxDelta_003E__1;

		[Token(Token = "0x4010D5E")]
		[FieldOffset(Offset = "0x1C")]
		internal UIWeaponSkinUpgraderPropertyItemController _0024this;

		[Token(Token = "0x4010D5F")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x4010D60")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x4010D61")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x17001321")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6012573")]
			[Address(RVA = "0x1B76490", Offset = "0x1B76490", VA = "0x1B76490", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001322")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6012574")]
			[Address(RVA = "0x1B76498", Offset = "0x1B76498", VA = "0x1B76498", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6012571")]
		[Address(RVA = "0x1B761CC", Offset = "0x1B761CC", VA = "0x1B761CC")]
		public _003CMoveToTargetX_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6012572")]
		[Address(RVA = "0x1B761EC", Offset = "0x1B761EC", VA = "0x1B761EC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6012575")]
		[Address(RVA = "0x1B764A0", Offset = "0x1B764A0", VA = "0x1B764A0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6012576")]
		[Address(RVA = "0x1B764B4", Offset = "0x1B764B4", VA = "0x1B764B4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4010D55")]
	[FieldOffset(Offset = "0x28")]
	private UIWeaponSkinUpgraderPropertyItemView m_View;

	[Token(Token = "0x4010D56")]
	[FieldOffset(Offset = "0x2C")]
	private WeaponSkinUpgradeInfoData m_FeatureInfo;

	[Token(Token = "0x4010D57")]
	[FieldOffset(Offset = "0x30")]
	private Coroutine m_ChosenMoveCoroutine;

	[Token(Token = "0x4010D58")]
	[FieldOffset(Offset = "0x34")]
	private WSUPropertyType m_Type;

	[Token(Token = "0x4010D59")]
	private const float m_UnchosenX = 0f;

	[Token(Token = "0x4010D5A")]
	private const float m_ChosenX = -8f;

	[Token(Token = "0x6012563")]
	[Address(RVA = "0x1B75364", Offset = "0x1B75364", VA = "0x1B75364")]
	public UIWeaponSkinUpgraderPropertyItemController()
	{
	}

	[Token(Token = "0x6012564")]
	[Address(RVA = "0x1B753E8", Offset = "0x1B753E8", VA = "0x1B753E8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012565")]
	[Address(RVA = "0x1B7548C", Offset = "0x1B7548C", VA = "0x1B7548C", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012566")]
	[Address(RVA = "0x1B754E8", Offset = "0x1B754E8", VA = "0x1B754E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012567")]
	[Address(RVA = "0x1B75754", Offset = "0x1B75754", VA = "0x1B75754", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6012568")]
	[Address(RVA = "0x1B74598", Offset = "0x1B74598", VA = "0x1B74598")]
	public void SetData(WeaponSkinFeature feature, WSUPropertyType type)
	{
	}

	[Token(Token = "0x6012569")]
	[Address(RVA = "0x1B75B18", Offset = "0x1B75B18", VA = "0x1B75B18")]
	private void ShowSkinProperty()
	{
	}

	[Token(Token = "0x601256A")]
	[Address(RVA = "0x1B75D48", Offset = "0x1B75D48", VA = "0x1B75D48")]
	private void OnShowProperty(object[] data)
	{
	}

	[Token(Token = "0x601256B")]
	[Address(RVA = "0x1B75E50", Offset = "0x1B75E50", VA = "0x1B75E50")]
	private void OnChosen()
	{
	}

	[Token(Token = "0x601256C")]
	[Address(RVA = "0x1B758A8", Offset = "0x1B758A8", VA = "0x1B758A8")]
	private void OnUnChosen()
	{
	}

	[Token(Token = "0x601256D")]
	[Address(RVA = "0x1B760D0", Offset = "0x1B760D0", VA = "0x1B760D0")]
	private IEnumerator MoveToTargetX(float targetX)
	{
		return null;
	}

	[Token(Token = "0x601256E")]
	[Address(RVA = "0x1B761D4", Offset = "0x1B761D4", VA = "0x1B761D4")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601256F")]
	[Address(RVA = "0x1B761DC", Offset = "0x1B761DC", VA = "0x1B761DC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012570")]
	[Address(RVA = "0x1B761E4", Offset = "0x1B761E4", VA = "0x1B761E4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
