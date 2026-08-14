using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20022D4")]
internal abstract class UIHudResultShowBaseController : UIHudMatchResultBaseShareController
{
	[Token(Token = "0x20022D5")]
	internal class AvatarProfileInfo
	{
		[Token(Token = "0x400D990")]
		[FieldOffset(Offset = "0x8")]
		internal string nickName;

		[Token(Token = "0x400D991")]
		[FieldOffset(Offset = "0x10")]
		internal ulong userId;

		[Token(Token = "0x400D992")]
		[FieldOffset(Offset = "0x18")]
		internal uint role;

		[Token(Token = "0x400D993")]
		[FieldOffset(Offset = "0x1C")]
		internal string firstKey;

		[Token(Token = "0x400D994")]
		[FieldOffset(Offset = "0x20")]
		internal string firstValue;

		[Token(Token = "0x400D995")]
		[FieldOffset(Offset = "0x24")]
		internal string secondKey;

		[Token(Token = "0x400D996")]
		[FieldOffset(Offset = "0x28")]
		internal string secondValue;

		[Token(Token = "0x400D997")]
		[FieldOffset(Offset = "0x2C")]
		internal List<uint> battleTags;

		[Token(Token = "0x600BFF8")]
		[Address(RVA = "0x13F5F2C", Offset = "0x13F5F2C", VA = "0x13F5F2C")]
		internal AvatarProfileInfo(PlayerData playerData)
		{
		}

		[Token(Token = "0x600BFF9")]
		[Address(RVA = "0x13F7DA0", Offset = "0x13F7DA0", VA = "0x13F7DA0")]
		internal AvatarProfileInfo(UGCPlayerStats playerStats, int[] scoreTypes, int ugcGameMode)
		{
		}
	}

	[Token(Token = "0x20022D6")]
	private sealed class _003CCoPlayEmotionAnimationd_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D998")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x400D999")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudResultShowBaseController _0024this;

		[Token(Token = "0x400D99A")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400D99B")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400D99C")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x170010A0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600BFFC")]
			[Address(RVA = "0x13F7B40", Offset = "0x13F7B40", VA = "0x13F7B40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010A1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BFFD")]
			[Address(RVA = "0x13F7B48", Offset = "0x13F7B48", VA = "0x13F7B48", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BFFA")]
		[Address(RVA = "0x13F6BA8", Offset = "0x13F6BA8", VA = "0x13F6BA8")]
		public _003CCoPlayEmotionAnimationd_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600BFFB")]
		[Address(RVA = "0x13F7884", Offset = "0x13F7884", VA = "0x13F7884", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BFFE")]
		[Address(RVA = "0x13F7B50", Offset = "0x13F7B50", VA = "0x13F7B50", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600BFFF")]
		[Address(RVA = "0x13F7B64", Offset = "0x13F7B64", VA = "0x13F7B64", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20022D7")]
	private sealed class _003CStartUIUnlock_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D99D")]
		[FieldOffset(Offset = "0x8")]
		internal UIHudResultShowBaseController _0024this;

		[Token(Token = "0x400D99E")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400D99F")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400D9A0")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170010A2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600C002")]
			[Address(RVA = "0x13F7CF4", Offset = "0x13F7CF4", VA = "0x13F7CF4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010A3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600C003")]
			[Address(RVA = "0x13F7CFC", Offset = "0x13F7CFC", VA = "0x13F7CFC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600C000")]
		[Address(RVA = "0x13F6BB0", Offset = "0x13F6BB0", VA = "0x13F6BB0")]
		public _003CStartUIUnlock_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600C001")]
		[Address(RVA = "0x13F7BEC", Offset = "0x13F7BEC", VA = "0x13F7BEC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600C004")]
		[Address(RVA = "0x13F7D04", Offset = "0x13F7D04", VA = "0x13F7D04", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600C005")]
		[Address(RVA = "0x13F7D18", Offset = "0x13F7D18", VA = "0x13F7D18", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D986")]
	[FieldOffset(Offset = "0x4C")]
	protected GameObject ResultShowInfo;

	[Token(Token = "0x400D987")]
	[FieldOffset(Offset = "0x50")]
	protected Transform result_Show_pos;

	[Token(Token = "0x400D988")]
	[FieldOffset(Offset = "0x54")]
	protected Camera camera_ob_result;

	[Token(Token = "0x400D989")]
	[FieldOffset(Offset = "0x58")]
	protected List<UIMaleAvatar> m_AvatarList;

	[Token(Token = "0x400D98A")]
	[FieldOffset(Offset = "0x5C")]
	protected int EMOTE_WAIT_TIME;

	[Token(Token = "0x400D98B")]
	[FieldOffset(Offset = "0x60")]
	protected int CLOSE_UI_UNLOCK_TIME;

	[Token(Token = "0x400D98C")]
	[FieldOffset(Offset = "0x64")]
	protected int scene_id_test;

	[Token(Token = "0x400D98D")]
	[FieldOffset(Offset = "0x68")]
	protected bool uiCloseLock;

	[Token(Token = "0x400D98E")]
	[FieldOffset(Offset = "0x6C")]
	private GameObject m_TeamFormatGO;

	[Token(Token = "0x400D98F")]
	[FieldOffset(Offset = "0x0")]
	private static Func<PlayerData, AvatarProfileInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600BFE4")]
	[Address(RVA = "0x13F3390", Offset = "0x13F3390", VA = "0x13F3390")]
	protected UIHudResultShowBaseController()
	{
	}

	[Token(Token = "0x600BFE5")]
	[Address(RVA = "0x13F3430", Offset = "0x13F3430", VA = "0x13F3430")]
	protected void InitResultPosition()
	{
	}

	[Token(Token = "0x600BFE6")]
	[Address(RVA = "0x13F3908", Offset = "0x13F3908", VA = "0x13F3908", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600BFE7")]
	[Address(RVA = "0x13F3BA4", Offset = "0x13F3BA4", VA = "0x13F3BA4")]
	protected void CreateCamera()
	{
	}

	[Token(Token = "0x600BFE8")]
	[Address(RVA = "0x13F3FA4", Offset = "0x13F3FA4", VA = "0x13F3FA4")]
	protected ResourceID GetTeamFormatByCount(int player_count, bool use2DBG = false)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BFE9")]
	[Address(RVA = "0x13F412C", Offset = "0x13F412C", VA = "0x13F412C")]
	protected void CreateAvatarInMatchResult(List<PlayerData> players, bool win)
	{
	}

	[Token(Token = "0x600BFEA")]
	[Address(RVA = "0x13F53B0", Offset = "0x13F53B0", VA = "0x13F53B0")]
	private void UpdateAvatarAnimatorInMatchResult(UIStatedAvatar avatar)
	{
	}

	[Token(Token = "0x600BFEB")]
	[Address(RVA = "0x13F56B0", Offset = "0x13F56B0", VA = "0x13F56B0")]
	protected void UISPHudCreateAvatarAndCallSign(List<PlayerData> players)
	{
	}

	[Token(Token = "0x600BFEC")]
	[Address(RVA = "0x13F4A64", Offset = "0x13F4A64", VA = "0x13F4A64")]
	protected UIMaleAvatar CreateMaleAvatar(PlayerData playerData, Transform parent, bool isMatchResult = false)
	{
		return null;
	}

	[Token(Token = "0x600BFED")]
	public abstract void CreateProfileCallSign(AvatarProfileInfo data, int index);

	[Token(Token = "0x600BFEE")]
	[Address(RVA = "0x13F52A8", Offset = "0x13F52A8", VA = "0x13F52A8")]
	protected bool IsDoubleWeild(WeaponSkinData data)
	{
		return default(bool);
	}

	[Token(Token = "0x600BFEF")]
	[Address(RVA = "0x13F6144", Offset = "0x13F6144", VA = "0x13F6144")]
	protected UIBaseProfileInfoController CreateBaseProfileInfoController(PlayerData data, int index, UIBaseView view, Transform parent, float yOffset = -0.1f)
	{
		return null;
	}

	[Token(Token = "0x600BFF0")]
	[Address(RVA = "0x13F64E4", Offset = "0x13F64E4", VA = "0x13F64E4")]
	protected Vector3 ScreenToLocalPosition(UIBaseView view, Vector3 pos)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600BFF1")]
	[Address(RVA = "0x13F66B8", Offset = "0x13F66B8", VA = "0x13F66B8", Slot = "39")]
	protected virtual void PlayAvatarsEmote()
	{
	}

	[Token(Token = "0x600BFF2")]
	[Address(RVA = "0x13F69F0", Offset = "0x13F69F0", VA = "0x13F69F0")]
	private IEnumerator CoPlayEmotionAnimationd(uint id)
	{
		return null;
	}

	[Token(Token = "0x600BFF3")]
	[Address(RVA = "0x13F6ADC", Offset = "0x13F6ADC", VA = "0x13F6ADC")]
	private IEnumerator StartUIUnlock()
	{
		return null;
	}

	[Token(Token = "0x600BFF4")]
	[Address(RVA = "0x13F6BB8", Offset = "0x13F6BB8", VA = "0x13F6BB8")]
	protected void CreateResultShow2DWindow(bool spectator, out Camera bgCamera, out Camera avatarCamera)
	{
	}

	[Token(Token = "0x600BFF5")]
	[Address(RVA = "0x13F7678", Offset = "0x13F7678", VA = "0x13F7678", Slot = "40")]
	protected virtual void PrepareShowAvatarData(out List<PlayerData> avatarData, out List<AvatarProfileInfo> profileData)
	{
	}

	[Token(Token = "0x600BFF6")]
	[Address(RVA = "0x13F780C", Offset = "0x13F780C", VA = "0x13F780C")]
	private static AvatarProfileInfo _003CPrepareShowAvatarData_003Em__0(PlayerData x)
	{
		return null;
	}

	[Token(Token = "0x600BFF7")]
	[Address(RVA = "0x13F787C", Offset = "0x13F787C", VA = "0x13F787C")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
