using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x20024E0")]
public class UIAvatarWindowController : UIBaseController, _Attribute
{
	[Token(Token = "0x20024E1")]
	private class TeamAvatar
	{
		[Token(Token = "0x400E4CD")]
		[FieldOffset(Offset = "0x8")]
		public ulong account_id;

		[Token(Token = "0x400E4CE")]
		[FieldOffset(Offset = "0x10")]
		public UIMaleAvatar avatar;

		[Token(Token = "0x400E4CF")]
		[FieldOffset(Offset = "0x14")]
		public UIPetAvatar pet_avatar;

		[Token(Token = "0x400E4D0")]
		[FieldOffset(Offset = "0x18")]
		public int pos_id;

		[Token(Token = "0x400E4D1")]
		[FieldOffset(Offset = "0x1C")]
		public uint avatar_id;

		[Token(Token = "0x400E4D2")]
		[FieldOffset(Offset = "0x20")]
		public uint show_weapon_id;

		[Token(Token = "0x400E4D3")]
		[FieldOffset(Offset = "0x24")]
		public uint pve_weapon_id;

		[Token(Token = "0x400E4D4")]
		[FieldOffset(Offset = "0x28")]
		public uint hand_weapon_id;

		[Token(Token = "0x400E4D5")]
		[FieldOffset(Offset = "0x2C")]
		public uint group_anim_id;

		[Token(Token = "0x400E4D6")]
		[FieldOffset(Offset = "0x30")]
		public uint show_bag_id;

		[Token(Token = "0x400E4D7")]
		[FieldOffset(Offset = "0x34")]
		public bool has_changefemale;

		[Token(Token = "0x400E4D8")]
		[FieldOffset(Offset = "0x35")]
		public bool has_changeavatarid;

		[Token(Token = "0x400E4D9")]
		[FieldOffset(Offset = "0x36")]
		public bool forcerefreshbag;

		[Token(Token = "0x600D4DD")]
		[Address(RVA = "0x13FD534", Offset = "0x13FD534", VA = "0x13FD534")]
		public TeamAvatar()
		{
		}
	}

	[Token(Token = "0x20024E2")]
	private class TeamAvatarPos
	{
		[Token(Token = "0x400E4DA")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 pos;

		[Token(Token = "0x400E4DB")]
		[FieldOffset(Offset = "0x14")]
		public Quaternion rotation;

		[Token(Token = "0x400E4DC")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 pos_pet;

		[Token(Token = "0x600D4DE")]
		[Address(RVA = "0x13FD53C", Offset = "0x13FD53C", VA = "0x13FD53C")]
		public TeamAvatarPos(Vector3 p, Quaternion r, Vector3 pet_p)
		{
		}
	}

	[Token(Token = "0x20024E3")]
	public class AvatarSetting
	{
		[Token(Token = "0x400E4DD")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 avatar_pos;

		[Token(Token = "0x400E4DE")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 avatar_rotation;

		[Token(Token = "0x400E4DF")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 avatar_scale;

		[Token(Token = "0x400E4E0")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 camera_pos;

		[Token(Token = "0x400E4E1")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 camera_rotaion;

		[Token(Token = "0x400E4E2")]
		[FieldOffset(Offset = "0x44")]
		public float avatar_input_angle;

		[Token(Token = "0x400E4E3")]
		[FieldOffset(Offset = "0x48")]
		public bool avatar_input;

		[Token(Token = "0x600D4DF")]
		[Address(RVA = "0x13FD3B4", Offset = "0x13FD3B4", VA = "0x13FD3B4")]
		public AvatarSetting()
		{
		}
	}

	[Token(Token = "0x20024E4")]
	public class AvatarPetSetting
	{
		[Token(Token = "0x400E4E4")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 avatar_pos;

		[Token(Token = "0x400E4E5")]
		[FieldOffset(Offset = "0x14")]
		public bool showState;

		[Token(Token = "0x400E4E6")]
		[FieldOffset(Offset = "0x18")]
		public float avatar_input_angle;

		[Token(Token = "0x600D4E0")]
		[Address(RVA = "0x13FD36C", Offset = "0x13FD36C", VA = "0x13FD36C")]
		public AvatarPetSetting(Vector3 pet_pos)
		{
		}
	}

	[Token(Token = "0x20024E5")]
	private sealed class _003CChatBubbleCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400E4E7")]
		[FieldOffset(Offset = "0x8")]
		internal Vector3 _003CheadPosition_003E__0;

		[Token(Token = "0x400E4E8")]
		[FieldOffset(Offset = "0x14")]
		internal UIAvatarWindowController _0024this;

		[Token(Token = "0x400E4E9")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x400E4EA")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x400E4EB")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x1700113C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600D4E3")]
			[Address(RVA = "0x13FCC90", Offset = "0x13FCC90", VA = "0x13FCC90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700113D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600D4E4")]
			[Address(RVA = "0x13FCC98", Offset = "0x13FCC98", VA = "0x13FCC98", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600D4E1")]
		[Address(RVA = "0x13FC8BC", Offset = "0x13FC8BC", VA = "0x13FC8BC")]
		public _003CChatBubbleCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600D4E2")]
		[Address(RVA = "0x13FC8C4", Offset = "0x13FC8C4", VA = "0x13FC8C4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600D4E5")]
		[Address(RVA = "0x13FCCA0", Offset = "0x13FCCA0", VA = "0x13FCCA0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600D4E6")]
		[Address(RVA = "0x13FCCB4", Offset = "0x13FCCB4", VA = "0x13FCCB4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20024E6")]
	private sealed class _003COnGroupMemberShowEmote_003Ec__AnonStorey2
	{
		[Token(Token = "0x400E4EC")]
		[FieldOffset(Offset = "0x8")]
		internal ulong localAccountId;

		[Token(Token = "0x600D4E7")]
		[Address(RVA = "0x13FCDC8", Offset = "0x13FCDC8", VA = "0x13FCDC8")]
		public _003COnGroupMemberShowEmote_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x600D4E8")]
		[Address(RVA = "0x13FCDD0", Offset = "0x13FCDD0", VA = "0x13FCDD0")]
		internal bool _003C_003Em__0(AccountEmoteRandomID e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20024E7")]
	private sealed class _003COnGroupMemberShowEmote_003Ec__AnonStorey3
	{
		[Token(Token = "0x400E4ED")]
		[FieldOffset(Offset = "0x8")]
		internal TeamAvatar p;

		[Token(Token = "0x600D4E9")]
		[Address(RVA = "0x13FCE1C", Offset = "0x13FCE1C", VA = "0x13FCE1C")]
		public _003COnGroupMemberShowEmote_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x600D4EA")]
		[Address(RVA = "0x13FCE24", Offset = "0x13FCE24", VA = "0x13FCE24")]
		internal bool _003C_003Em__0(AccountEmoteRandomID e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20024E8")]
	private sealed class _003COnGroupLeaveNtf_003Ec__AnonStorey4
	{
		[Token(Token = "0x400E4EE")]
		[FieldOffset(Offset = "0x8")]
		internal ulong leaver_id;

		[Token(Token = "0x600D4EB")]
		[Address(RVA = "0x13FCD80", Offset = "0x13FCD80", VA = "0x13FCD80")]
		public _003COnGroupLeaveNtf_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x600D4EC")]
		[Address(RVA = "0x13FCD88", Offset = "0x13FCD88", VA = "0x13FCD88")]
		internal bool _003C_003Em__0(TeamAvatar s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20024E9")]
	private sealed class _003CIsAvatarTeammate_003Ec__AnonStorey5
	{
		[Token(Token = "0x400E4EF")]
		[FieldOffset(Offset = "0x8")]
		internal ulong avatarId;

		[Token(Token = "0x600D4ED")]
		[Address(RVA = "0x13FCD3C", Offset = "0x13FCD3C", VA = "0x13FCD3C")]
		public _003CIsAvatarTeammate_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x600D4EE")]
		[Address(RVA = "0x13FCD44", Offset = "0x13FCD44", VA = "0x13FCD44")]
		internal bool _003C_003Em__0(TeamAvatar s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20024EA")]
	private sealed class _003CRefreshTeamatePVEWeapon_003Ec__AnonStorey6
	{
		[Token(Token = "0x400E4F0")]
		[FieldOffset(Offset = "0x8")]
		internal TeamAvatar ta;

		[Token(Token = "0x600D4EF")]
		[Address(RVA = "0x13FD294", Offset = "0x13FD294", VA = "0x13FD294")]
		public _003CRefreshTeamatePVEWeapon_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x600D4F0")]
		[Address(RVA = "0x13FD29C", Offset = "0x13FD29C", VA = "0x13FD29C")]
		internal bool _003C_003Em__0(GroupMemberInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20024EB")]
	private sealed class _003CPlayAvatarShowPose_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400E4F1")]
		[FieldOffset(Offset = "0x8")]
		internal UIMaleAvatar avatar;

		[Token(Token = "0x400E4F2")]
		[FieldOffset(Offset = "0xC")]
		internal EFrontendUIType _003CpreCamera_003E__0;

		[Token(Token = "0x400E4F3")]
		[FieldOffset(Offset = "0x10")]
		internal float seconds;

		[Token(Token = "0x400E4F4")]
		[FieldOffset(Offset = "0x14")]
		internal UINavigationData _003CnData_003E__0;

		[Token(Token = "0x400E4F5")]
		[FieldOffset(Offset = "0x18")]
		internal UIAvatarWindowController _0024this;

		[Token(Token = "0x400E4F6")]
		[FieldOffset(Offset = "0x1C")]
		internal object _0024current;

		[Token(Token = "0x400E4F7")]
		[FieldOffset(Offset = "0x20")]
		internal bool _0024disposing;

		[Token(Token = "0x400E4F8")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024PC;

		[Token(Token = "0x1700113E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600D4F3")]
			[Address(RVA = "0x13FD1E8", Offset = "0x13FD1E8", VA = "0x13FD1E8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700113F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600D4F4")]
			[Address(RVA = "0x13FD1F0", Offset = "0x13FD1F0", VA = "0x13FD1F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600D4F1")]
		[Address(RVA = "0x13FCF3C", Offset = "0x13FCF3C", VA = "0x13FCF3C")]
		public _003CPlayAvatarShowPose_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600D4F2")]
		[Address(RVA = "0x13FCF44", Offset = "0x13FCF44", VA = "0x13FCF44", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600D4F5")]
		[Address(RVA = "0x13FD1F8", Offset = "0x13FD1F8", VA = "0x13FD1F8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600D4F6")]
		[Address(RVA = "0x13FD20C", Offset = "0x13FD20C", VA = "0x13FD20C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20024EC")]
	private sealed class _003COnGroupReadyNtf_003Ec__AnonStorey7
	{
		[Token(Token = "0x400E4F9")]
		[FieldOffset(Offset = "0x8")]
		internal GroupMemberInfo mem;

		[Token(Token = "0x600D4F7")]
		[Address(RVA = "0x13FCE8C", Offset = "0x13FCE8C", VA = "0x13FCE8C")]
		public _003COnGroupReadyNtf_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x600D4F8")]
		[Address(RVA = "0x13FCE94", Offset = "0x13FCE94", VA = "0x13FCE94")]
		internal bool _003C_003Em__0(TeamAvatar s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20024ED")]
	private sealed class _003COnSyncOptionalMapResNtf_003Ec__AnonStorey8
	{
		[Token(Token = "0x400E4FA")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accountId;

		[Token(Token = "0x600D4F9")]
		[Address(RVA = "0x13FCEF4", Offset = "0x13FCEF4", VA = "0x13FCEF4")]
		public _003COnSyncOptionalMapResNtf_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x600D4FA")]
		[Address(RVA = "0x13FCEFC", Offset = "0x13FCEFC", VA = "0x13FCEFC")]
		internal bool _003C_003Em__0(TeamAvatar s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20024EE")]
	private sealed class _003ConGroupStopNtf_003Ec__AnonStorey9
	{
		[Token(Token = "0x400E4FB")]
		[FieldOffset(Offset = "0x8")]
		internal GroupMemberInfo stopper;

		[Token(Token = "0x600D4FB")]
		[Address(RVA = "0x13FD304", Offset = "0x13FD304", VA = "0x13FD304")]
		public _003ConGroupStopNtf_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x600D4FC")]
		[Address(RVA = "0x13FD30C", Offset = "0x13FD30C", VA = "0x13FD30C")]
		internal bool _003C_003Em__0(TeamAvatar s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E495")]
	[FieldOffset(Offset = "0x28")]
	private UIAvatarWindowView m_View;

	[Token(Token = "0x400E496")]
	[FieldOffset(Offset = "0x2C")]
	private UIMaleAvatar m_Avatar;

	[Token(Token = "0x400E497")]
	[FieldOffset(Offset = "0x30")]
	private UIPetAvatar m_PetAvatar;

	[Token(Token = "0x400E498")]
	[FieldOffset(Offset = "0x34")]
	private GameObject m_PetAvatarReplacer;

	[Token(Token = "0x400E499")]
	[FieldOffset(Offset = "0x38")]
	private proto.PetInfo m_CurrentShowPetInfo;

	[Token(Token = "0x400E49A")]
	[FieldOffset(Offset = "0x3C")]
	private float m_PetLobbyScale;

	[Token(Token = "0x400E49B")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_AvatarCamera;

	[Token(Token = "0x400E49C")]
	[FieldOffset(Offset = "0x44")]
	private Camera m_Camera;

	[Token(Token = "0x400E49D")]
	[FieldOffset(Offset = "0x48")]
	private UIAvatarInputHandler m_AvatarInput;

	[Token(Token = "0x400E49E")]
	[FieldOffset(Offset = "0x4C")]
	private RenderTexture m_DynamicRenderTexture;

	[Token(Token = "0x400E49F")]
	[FieldOffset(Offset = "0x50")]
	private List<TeamAvatar> m_teamAvatars;

	[Token(Token = "0x400E4A0")]
	[FieldOffset(Offset = "0x54")]
	private List<UIGroupMemberInfoController> m_NamePanels;

	[Token(Token = "0x400E4A1")]
	[FieldOffset(Offset = "0x58")]
	private List<GameObject> m_AvatarParticleList;

	[Token(Token = "0x400E4A2")]
	[FieldOffset(Offset = "0x5C")]
	private UIModelGroup m_ModelGroup;

	[Token(Token = "0x400E4A3")]
	[FieldOffset(Offset = "0x60")]
	private UIModelAvatar m_ModelAvatar;

	[Token(Token = "0x400E4A4")]
	[FieldOffset(Offset = "0x64")]
	private bool m_AvatarShowCached;

	[Token(Token = "0x400E4A5")]
	[FieldOffset(Offset = "0x68")]
	private EFrontendUIType m_CurrentCameraUIType;

	[Token(Token = "0x400E4A6")]
	[FieldOffset(Offset = "0x6C")]
	private GameObject avatarLight;

	[Token(Token = "0x400E4A7")]
	[FieldOffset(Offset = "0x70")]
	private GameObject m_guidePetAcion;

	[Token(Token = "0x400E4A8")]
	[FieldOffset(Offset = "0x74")]
	private GameObject m_AvatarGuideEffect;

	[Token(Token = "0x400E4A9")]
	[FieldOffset(Offset = "0x78")]
	private List<int> m_AvailableTeamNums;

	[Token(Token = "0x400E4AA")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_NeedMoveCameraGradual;

	[Token(Token = "0x400E4AB")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 m_TargetCameraPos;

	[Token(Token = "0x400E4AC")]
	[FieldOffset(Offset = "0x8C")]
	public float CameraMoveMaxDistance;

	[Token(Token = "0x400E4AD")]
	[FieldOffset(Offset = "0x90")]
	private uint m_LobbyProfileDelayCall;

	[Token(Token = "0x400E4AE")]
	[FieldOffset(Offset = "0x94")]
	private Dictionary<int, TeamAvatarPos> m_DictPosition;

	[Token(Token = "0x400E4AF")]
	[FieldOffset(Offset = "0x98")]
	private Dictionary<int, TeamAvatarPos> m_DictPentaPosition;

	[Token(Token = "0x400E4B0")]
	[FieldOffset(Offset = "0x9C")]
	private Vector3[] m_NamePanelPosArray;

	[Token(Token = "0x400E4B1")]
	[FieldOffset(Offset = "0xA0")]
	private Vector3[] m_PentaNamePanelPosArray;

	[Token(Token = "0x400E4B2")]
	private const float srcScreenRatio = 0.5625f;

	[Token(Token = "0x400E4B3")]
	private const float heightOffset = 0.13f;

	[Token(Token = "0x400E4B4")]
	private const float widthOffset = 0.1f;

	[Token(Token = "0x400E4B5")]
	[FieldOffset(Offset = "0xA4")]
	private Vector3[] chatBubblePosition;

	[Token(Token = "0x400E4B6")]
	private const float ipadHeight = 3f;

	[Token(Token = "0x400E4B7")]
	private const float ipadWidth = 4f;

	[Token(Token = "0x400E4B8")]
	private const float LobbyDefaultAvatarScale = 380f;

	[Token(Token = "0x400E4B9")]
	[FieldOffset(Offset = "0xA8")]
	private Dictionary<int, AvatarSetting> AVATAR_SETTING;

	[Token(Token = "0x400E4BA")]
	[FieldOffset(Offset = "0xAC")]
	private Dictionary<int, AvatarPetSetting> AVATAR_PET_SETTING;

	[Token(Token = "0x400E4BB")]
	[FieldOffset(Offset = "0xB0")]
	private Dictionary<int, AvatarPetSetting> AVATAR_PET_REPLACE_SETTING;

	[Token(Token = "0x400E4BC")]
	[FieldOffset(Offset = "0xB4")]
	private UIModelFriends m_ModelFriends;

	[Token(Token = "0x400E4BD")]
	[FieldOffset(Offset = "0xB8")]
	private UIModelCollection m_ModelCollection;

	[Token(Token = "0x400E4BE")]
	[FieldOffset(Offset = "0xBC")]
	private UIModelPVE m_ModelPVE;

	[Token(Token = "0x400E4BF")]
	[FieldOffset(Offset = "0xC0")]
	private ulong _003CTargetShowPopMenuAccountID_003Ek__BackingField;

	[Token(Token = "0x400E4C0")]
	[FieldOffset(Offset = "0xC8")]
	private bool m_isInLobby;

	[Token(Token = "0x400E4C1")]
	[FieldOffset(Offset = "0xCC")]
	private UIHDStandLobbyInputHandler m_HDStandLobbyInputHandler;

	[Token(Token = "0x400E4C2")]
	[FieldOffset(Offset = "0xD0")]
	private UIHDPetInputHandler m_HDPetInputHandler;

	[Token(Token = "0x400E4C3")]
	[FieldOffset(Offset = "0xD4")]
	private Animator m_CameraAnim;

	[Token(Token = "0x400E4C4")]
	[FieldOffset(Offset = "0xD8")]
	private bool m_isAvatarInGroup;

	[Token(Token = "0x400E4C5")]
	[FieldOffset(Offset = "0xD9")]
	private bool m_isPetInEmote;

	[Token(Token = "0x400E4C6")]
	[FieldOffset(Offset = "0xDA")]
	private bool m_isEnterYard;

	[Token(Token = "0x400E4C7")]
	[FieldOffset(Offset = "0xDC")]
	private GameObject m_InCaptainLobbyVFX;

	[Token(Token = "0x400E4C8")]
	[FieldOffset(Offset = "0xE0")]
	private Animator m_InCaptainLobbyVFXAni;

	[Token(Token = "0x400E4C9")]
	[FieldOffset(Offset = "0x0")]
	private static Func<TeamAvatar, UIMaleAvatar> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400E4CA")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<int> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400E4CB")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<int> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400E4CC")]
	[FieldOffset(Offset = "0xC")]
	private static Predicate<int> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x1700113B")]
	public ulong TargetShowPopMenuAccountID
	{
		[Token(Token = "0x600D461")]
		[Address(RVA = "0x298C198", Offset = "0x298C198", VA = "0x298C198")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600D460")]
		[Address(RVA = "0x298C188", Offset = "0x298C188", VA = "0x298C188")]
		set
		{
		}
	}

	[Token(Token = "0x600D45E")]
	[Address(RVA = "0x298A140", Offset = "0x298A140", VA = "0x298A140")]
	public UIAvatarWindowController()
	{
	}

	[Token(Token = "0x600D45F")]
	[Address(RVA = "0x298C0E4", Offset = "0x298C0E4", VA = "0x298C0E4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D462")]
	[Address(RVA = "0x298C1A0", Offset = "0x298C1A0", VA = "0x298C1A0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D463")]
	[Address(RVA = "0x2993B24", Offset = "0x2993B24", VA = "0x2993B24")]
	private void OnAvatarClothUpdate(object[] data)
	{
	}

	[Token(Token = "0x600D464")]
	[Address(RVA = "0x2993DCC", Offset = "0x2993DCC", VA = "0x2993DCC")]
	private void OnAvatarUpdate(object[] data)
	{
	}

	[Token(Token = "0x600D465")]
	[Address(RVA = "0x2993B8C", Offset = "0x2993B8C", VA = "0x2993B8C")]
	private void CheckClothPrivilege()
	{
	}

	[Token(Token = "0x600D466")]
	[Address(RVA = "0x2993E34", Offset = "0x2993E34", VA = "0x2993E34", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D467")]
	[Address(RVA = "0x2991410", Offset = "0x2991410", VA = "0x2991410")]
	private void CreatePetAvatar(object[] data)
	{
	}

	[Token(Token = "0x600D468")]
	[Address(RVA = "0x2997AB0", Offset = "0x2997AB0", VA = "0x2997AB0")]
	public void CreateAvatarLight(EFrontendUIType uitype)
	{
	}

	[Token(Token = "0x600D469")]
	[Address(RVA = "0x2997F90", Offset = "0x2997F90", VA = "0x2997F90")]
	private void OnShowPetActionGuide(object[] param)
	{
	}

	[Token(Token = "0x600D46A")]
	[Address(RVA = "0x2997FEC", Offset = "0x2997FEC", VA = "0x2997FEC")]
	private void OnHidePetActionGuide(object[] param)
	{
	}

	[Token(Token = "0x600D46B")]
	[Address(RVA = "0x29983B0", Offset = "0x29983B0", VA = "0x29983B0")]
	private void OnShowAvatarGuideEffect(object[] param)
	{
	}

	[Token(Token = "0x600D46C")]
	[Address(RVA = "0x299840C", Offset = "0x299840C", VA = "0x299840C")]
	private void OnHideAvatarGuideEffect(object[] param)
	{
	}

	[Token(Token = "0x600D46D")]
	[Address(RVA = "0x2998144", Offset = "0x2998144", VA = "0x2998144")]
	private void OnClickPet()
	{
	}

	[Token(Token = "0x600D46E")]
	[Address(RVA = "0x2997010", Offset = "0x2997010", VA = "0x2997010")]
	private void OnDestoryAvatarParticle(object[] data)
	{
	}

	[Token(Token = "0x600D46F")]
	[Address(RVA = "0x2998740", Offset = "0x2998740", VA = "0x2998740")]
	private void OnCreateAvatarParticle(object[] data)
	{
	}

	[Token(Token = "0x600D470")]
	[Address(RVA = "0x2998BAC", Offset = "0x2998BAC", VA = "0x2998BAC")]
	private void OnAvatarInitReady(bool isLocal)
	{
	}

	[Token(Token = "0x600D471")]
	[Address(RVA = "0x2999178", Offset = "0x2999178", VA = "0x2999178")]
	private void OnWardrobeEnter(object[] data)
	{
	}

	[Token(Token = "0x600D472")]
	[Address(RVA = "0x29991E4", Offset = "0x29991E4", VA = "0x29991E4")]
	private void OnPetWindowEnter(object[] data)
	{
	}

	[Token(Token = "0x600D473")]
	[Address(RVA = "0x2999250", Offset = "0x2999250", VA = "0x2999250")]
	private void OnProfileEnter(object[] data)
	{
	}

	[Token(Token = "0x600D474")]
	[Address(RVA = "0x2999CB4", Offset = "0x2999CB4", VA = "0x2999CB4")]
	private void OnProfileExit(object[] data)
	{
	}

	[Token(Token = "0x600D475")]
	[Address(RVA = "0x2999E8C", Offset = "0x2999E8C", VA = "0x2999E8C")]
	private void OnPVEPrepareEnter(object[] data)
	{
	}

	[Token(Token = "0x600D476")]
	[Address(RVA = "0x2999F08", Offset = "0x2999F08", VA = "0x2999F08")]
	private void ChangeAvatarCamera(object[] data)
	{
	}

	[Token(Token = "0x600D477")]
	[Address(RVA = "0x2992730", Offset = "0x2992730", VA = "0x2992730")]
	private void OnAvatarCameraStateChange(object[] data)
	{
	}

	[Token(Token = "0x600D478")]
	[Address(RVA = "0x299A03C", Offset = "0x299A03C", VA = "0x299A03C")]
	private void OnAvatarInputEnableState(object[] data)
	{
	}

	[Token(Token = "0x600D479")]
	[Address(RVA = "0x299A18C", Offset = "0x299A18C", VA = "0x299A18C")]
	private void OnAvatarStateChange(object[] data)
	{
	}

	[Token(Token = "0x600D47A")]
	[Address(RVA = "0x299A404", Offset = "0x299A404", VA = "0x299A404")]
	private IEnumerator ChatBubbleCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600D47B")]
	[Address(RVA = "0x299A4D0", Offset = "0x299A4D0", VA = "0x299A4D0")]
	private void OnGroupChangeNtf(object[] data)
	{
	}

	[Token(Token = "0x600D47C")]
	[Address(RVA = "0x299C00C", Offset = "0x299C00C", VA = "0x299C00C")]
	private void FixTeammatePosID(TeamAvatar teammate)
	{
	}

	[Token(Token = "0x600D47D")]
	[Address(RVA = "0x299CA40", Offset = "0x299CA40", VA = "0x299CA40")]
	private void OnPetHdMoveChanged(object[] data)
	{
	}

	[Token(Token = "0x600D47E")]
	[Address(RVA = "0x2992A7C", Offset = "0x2992A7C", VA = "0x2992A7C")]
	private void OnLobbyGroupEnter(object[] data)
	{
	}

	[Token(Token = "0x600D47F")]
	[Address(RVA = "0x299BC64", Offset = "0x299BC64", VA = "0x299BC64")]
	private Vector3 GetNamePanelsPositionByPosId(int posId)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600D480")]
	[Address(RVA = "0x299F9A0", Offset = "0x299F9A0", VA = "0x299F9A0")]
	private Vector3 CalcChatBubblePositionOffset(float ratio, Vector3 chatBubblePosition)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600D481")]
	[Address(RVA = "0x299FA9C", Offset = "0x299FA9C", VA = "0x299FA9C")]
	private void OnGroupInfoClear(object[] data)
	{
	}

	[Token(Token = "0x600D482")]
	[Address(RVA = "0x29924E0", Offset = "0x29924E0", VA = "0x29924E0")]
	private void OnLobbyEnter(object[] data)
	{
	}

	[Token(Token = "0x600D483")]
	[Address(RVA = "0x299FC00", Offset = "0x299FC00", VA = "0x299FC00")]
	private void OnEnterPortraitCloseup(object[] data)
	{
	}

	[Token(Token = "0x600D484")]
	[Address(RVA = "0x299FC74", Offset = "0x299FC74", VA = "0x299FC74")]
	private void OnEnterAvatarProfile(object[] data)
	{
	}

	[Token(Token = "0x600D485")]
	[Address(RVA = "0x299FCEC", Offset = "0x299FCEC", VA = "0x299FCEC")]
	private void OnEnterWeaponSkinUpgrader(object[] data)
	{
	}

	[Token(Token = "0x600D486")]
	[Address(RVA = "0x299FD64", Offset = "0x299FD64", VA = "0x299FD64")]
	private void OnEnterLegendClothVault(object[] data)
	{
	}

	[Token(Token = "0x600D487")]
	[Address(RVA = "0x299FDDC", Offset = "0x299FDDC", VA = "0x299FDDC")]
	private void OnExitLegendClothVault(object[] data)
	{
	}

	[Token(Token = "0x600D488")]
	[Address(RVA = "0x299FE60", Offset = "0x299FE60", VA = "0x299FE60")]
	private void OnDisableTeamAvatar(object[] data)
	{
	}

	[Token(Token = "0x600D489")]
	[Address(RVA = "0x29A0240", Offset = "0x29A0240", VA = "0x29A0240")]
	private void OnBigEventEnter(object[] data)
	{
	}

	[Token(Token = "0x600D48A")]
	[Address(RVA = "0x29A033C", Offset = "0x29A033C", VA = "0x29A033C")]
	private void OnMallEnter(object[] data)
	{
	}

	[Token(Token = "0x600D48B")]
	[Address(RVA = "0x29A0444", Offset = "0x29A0444", VA = "0x29A0444")]
	private void OnForgeEnter(object[] data)
	{
	}

	[Token(Token = "0x600D48C")]
	[Address(RVA = "0x29A0540", Offset = "0x29A0540", VA = "0x29A0540")]
	private void OnGachaEnter(object[] data)
	{
	}

	[Token(Token = "0x600D48D")]
	[Address(RVA = "0x29A0654", Offset = "0x29A0654", VA = "0x29A0654")]
	private void OnCollectionEnter(object[] data)
	{
	}

	[Token(Token = "0x600D48E")]
	[Address(RVA = "0x29A0750", Offset = "0x29A0750", VA = "0x29A0750")]
	private void OnIAPBundleEnter(object[] data)
	{
	}

	[Token(Token = "0x600D48F")]
	[Address(RVA = "0x29A08D8", Offset = "0x29A08D8", VA = "0x29A08D8")]
	private void OnProfileShareEnter(object[] data)
	{
	}

	[Token(Token = "0x600D490")]
	[Address(RVA = "0x29A1244", Offset = "0x29A1244", VA = "0x29A1244")]
	private void OnLadderEnter(object[] data)
	{
	}

	[Token(Token = "0x600D491")]
	[Address(RVA = "0x29A12B0", Offset = "0x29A12B0", VA = "0x29A12B0")]
	private void OnGainItemEnter(object[] data)
	{
	}

	[Token(Token = "0x600D492")]
	[Address(RVA = "0x29A131C", Offset = "0x29A131C", VA = "0x29A131C")]
	private void OnElitePassEnter(object[] data)
	{
	}

	[Token(Token = "0x600D493")]
	[Address(RVA = "0x29995D0", Offset = "0x29995D0", VA = "0x29995D0")]
	private void AutoModifyCamera()
	{
	}

	[Token(Token = "0x600D494")]
	[Address(RVA = "0x29A1390", Offset = "0x29A1390", VA = "0x29A1390")]
	private void OnGroupQuitClearAvatar(object[] data)
	{
	}

	[Token(Token = "0x600D495")]
	[Address(RVA = "0x29A17D8", Offset = "0x29A17D8", VA = "0x29A17D8")]
	private void OnGroupCreate(object[] data)
	{
	}

	[Token(Token = "0x600D496")]
	[Address(RVA = "0x29930B8", Offset = "0x29930B8", VA = "0x29930B8")]
	private void OnGroupJoin(object[] data)
	{
	}

	[Token(Token = "0x600D497")]
	[Address(RVA = "0x29A185C", Offset = "0x29A185C", VA = "0x29A185C")]
	private void OnGroupMemberShowEmote(object[] data)
	{
	}

	[Token(Token = "0x600D498")]
	[Address(RVA = "0x29A2074", Offset = "0x29A2074", VA = "0x29A2074")]
	private void OnGroupPetShowAction(object[] data)
	{
	}

	[Token(Token = "0x600D499")]
	[Address(RVA = "0x29A245C", Offset = "0x29A245C", VA = "0x29A245C")]
	private void UpdateMemberPetShow()
	{
	}

	[Token(Token = "0x600D49A")]
	[Address(RVA = "0x299BE24", Offset = "0x299BE24", VA = "0x299BE24")]
	private TeamAvatarPos GetAvatarPositionByPosId(int posId)
	{
		return null;
	}

	[Token(Token = "0x600D49B")]
	[Address(RVA = "0x299C9D4", Offset = "0x299C9D4", VA = "0x299C9D4")]
	private Dictionary<int, TeamAvatarPos> GetAvatarPosDictByGroupMode(HHDIPHFOBFO groupMode)
	{
		return null;
	}

	[Token(Token = "0x600D49C")]
	[Address(RVA = "0x29A307C", Offset = "0x29A307C", VA = "0x29A307C")]
	private void UpdateAvatarPetShow()
	{
	}

	[Token(Token = "0x600D49D")]
	[Address(RVA = "0x29A3F20", Offset = "0x29A3F20", VA = "0x29A3F20")]
	private void UpdateGroupAvatarsClothes()
	{
	}

	[Token(Token = "0x600D49E")]
	[Address(RVA = "0x29A4AD4", Offset = "0x29A4AD4", VA = "0x29A4AD4")]
	private void RefreshPinData()
	{
	}

	[Token(Token = "0x600D49F")]
	[Address(RVA = "0x29A4FEC", Offset = "0x29A4FEC", VA = "0x29A4FEC")]
	private void RefreshRebuildAvatar()
	{
	}

	[Token(Token = "0x600D4A0")]
	[Address(RVA = "0x29A629C", Offset = "0x29A629C", VA = "0x29A629C")]
	private void RefrshTeamBag()
	{
	}

	[Token(Token = "0x600D4A1")]
	[Address(RVA = "0x29A542C", Offset = "0x29A542C", VA = "0x29A542C")]
	private void RecreateTeamAvatar(GroupMemberInfo member, TeamAvatar teamav)
	{
	}

	[Token(Token = "0x600D4A2")]
	[Address(RVA = "0x299CB88", Offset = "0x299CB88", VA = "0x299CB88")]
	private void ShowAvatars()
	{
	}

	[Token(Token = "0x600D4A3")]
	[Address(RVA = "0x29A6FDC", Offset = "0x29A6FDC", VA = "0x29A6FDC")]
	private void OnGroupLeaveNtf(object[] data)
	{
	}

	[Token(Token = "0x600D4A4")]
	[Address(RVA = "0x29A7684", Offset = "0x29A7684", VA = "0x29A7684")]
	public bool IsAvatarTeammate(ulong avatarId)
	{
		return default(bool);
	}

	[Token(Token = "0x600D4A5")]
	[Address(RVA = "0x299978C", Offset = "0x299978C", VA = "0x299978C")]
	private void PlayAvatarShowPose(bool takeWeapon = false, bool force = false)
	{
	}

	[Token(Token = "0x600D4A6")]
	[Address(RVA = "0x29A6BF0", Offset = "0x29A6BF0", VA = "0x29A6BF0")]
	private bool ShowPVEWeapon()
	{
		return default(bool);
	}

	[Token(Token = "0x600D4A7")]
	[Address(RVA = "0x29A7A20", Offset = "0x29A7A20", VA = "0x29A7A20")]
	private void OnRefreshWeapon(object[] data)
	{
	}

	[Token(Token = "0x600D4A8")]
	[Address(RVA = "0x29A7F28", Offset = "0x29A7F28", VA = "0x29A7F28")]
	private void OnRefreshWeaponOnHand(object[] data)
	{
	}

	[Token(Token = "0x600D4A9")]
	[Address(RVA = "0x29A82F0", Offset = "0x29A82F0", VA = "0x29A82F0")]
	private void OnPlayerBackpackUpdate(object[] data)
	{
	}

	[Token(Token = "0x600D4AA")]
	[Address(RVA = "0x29A7FF0", Offset = "0x29A7FF0", VA = "0x29A7FF0")]
	private void RefreshSelfWeaponOnHand()
	{
	}

	[Token(Token = "0x600D4AB")]
	[Address(RVA = "0x29A807C", Offset = "0x29A807C", VA = "0x29A807C")]
	private void RefreshTeamateWeaponOnHand(object[] data)
	{
	}

	[Token(Token = "0x600D4AC")]
	[Address(RVA = "0x29A8520", Offset = "0x29A8520", VA = "0x29A8520")]
	private void RefreshTeamatePVEWeapon()
	{
	}

	[Token(Token = "0x600D4AD")]
	[Address(RVA = "0x29A7900", Offset = "0x29A7900", VA = "0x29A7900")]
	private IEnumerator PlayAvatarShowPose(UIMaleAvatar avatar, float seconds)
	{
		return null;
	}

	[Token(Token = "0x600D4AE")]
	[Address(RVA = "0x29A77F0", Offset = "0x29A77F0", VA = "0x29A77F0")]
	private void OnStopAvatarShowPose(object[] data)
	{
	}

	[Token(Token = "0x600D4AF")]
	[Address(RVA = "0x29A8860", Offset = "0x29A8860", VA = "0x29A8860")]
	private void OnInviteBtnClick(int member_idx, ulong friendid)
	{
	}

	[Token(Token = "0x600D4B0")]
	[Address(RVA = "0x29A89C8", Offset = "0x29A89C8", VA = "0x29A89C8")]
	private void OnGroupQuit(object[] data)
	{
	}

	[Token(Token = "0x600D4B1")]
	[Address(RVA = "0x29A8C08", Offset = "0x29A8C08", VA = "0x29A8C08")]
	private void OnGroupDismissNtf(object[] data)
	{
	}

	[Token(Token = "0x600D4B2")]
	[Address(RVA = "0x29A8D58", Offset = "0x29A8D58", VA = "0x29A8D58")]
	private void OnGroupReadyNtf(object[] data)
	{
	}

	[Token(Token = "0x600D4B3")]
	[Address(RVA = "0x29A92DC", Offset = "0x29A92DC", VA = "0x29A92DC")]
	private void OnSyncOptionalMapResNtf(object[] data)
	{
	}

	[Token(Token = "0x600D4B4")]
	[Address(RVA = "0x299C314", Offset = "0x299C314", VA = "0x299C314")]
	private void OnTeammateMuteStateChange(object[] data)
	{
	}

	[Token(Token = "0x600D4B5")]
	[Address(RVA = "0x29A9594", Offset = "0x29A9594", VA = "0x29A9594")]
	private void OnTeammateProfileSpeakerStateChange(object[] data)
	{
	}

	[Token(Token = "0x600D4B6")]
	[Address(RVA = "0x29A9888", Offset = "0x29A9888", VA = "0x29A9888")]
	private void onGroupStopNtf(object[] data)
	{
	}

	[Token(Token = "0x600D4B7")]
	[Address(RVA = "0x29A9DAC", Offset = "0x29A9DAC", VA = "0x29A9DAC")]
	private Vector3 ScreenToLocalPosition(Vector3 pos)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600D4B8")]
	[Address(RVA = "0x29A9F78", Offset = "0x29A9F78", VA = "0x29A9F78")]
	private void Update()
	{
	}

	[Token(Token = "0x600D4B9")]
	[Address(RVA = "0x2990340", Offset = "0x2990340", VA = "0x2990340")]
	private void SetAvatarRelatedPos(EFrontendUIType uiType)
	{
	}

	[Token(Token = "0x600D4BA")]
	[Address(RVA = "0x299722C", Offset = "0x299722C", VA = "0x299722C")]
	private void UpdatePetAvataReplacer()
	{
	}

	[Token(Token = "0x600D4BB")]
	[Address(RVA = "0x2997450", Offset = "0x2997450", VA = "0x2997450")]
	private void SetAvatarPet()
	{
	}

	[Token(Token = "0x600D4BC")]
	[Address(RVA = "0x29AA808", Offset = "0x29AA808", VA = "0x29AA808")]
	private void ShowPetLobbyAction(object[] param)
	{
	}

	[Token(Token = "0x600D4BD")]
	[Address(RVA = "0x29A7E3C", Offset = "0x29A7E3C", VA = "0x29A7E3C")]
	private bool ShowWeaponInCurrentUI()
	{
		return default(bool);
	}

	[Token(Token = "0x600D4BE")]
	[Address(RVA = "0x299FF3C", Offset = "0x299FF3C", VA = "0x299FF3C")]
	private void ShowTeamAvatars(bool isVisible)
	{
	}

	[Token(Token = "0x600D4BF")]
	[Address(RVA = "0x29AAB3C", Offset = "0x29AAB3C", VA = "0x29AAB3C")]
	private void OnResetGachaAvatar(object[] data)
	{
	}

	[Token(Token = "0x600D4C0")]
	[Address(RVA = "0x29A6C48", Offset = "0x29A6C48", VA = "0x29A6C48")]
	private void ShowWeaponAnim(uint skinId, UIMaleAvatar avatar, bool force = false)
	{
	}

	[Token(Token = "0x600D4C1")]
	[Address(RVA = "0x29A7EAC", Offset = "0x29A7EAC", VA = "0x29A7EAC")]
	public bool CheckIsDualWield(WeaponSkinData data)
	{
		return default(bool);
	}

	[Token(Token = "0x600D4C2")]
	[Address(RVA = "0x29AACC0", Offset = "0x29AACC0", VA = "0x29AACC0", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D4C3")]
	[Address(RVA = "0x29A3B74", Offset = "0x29A3B74", VA = "0x29A3B74")]
	private bool CheckPetAbStateChanged(UIPetAvatar pet, GroupMemberPetInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x600D4C4")]
	[Address(RVA = "0x29AB11C", Offset = "0x29AB11C", VA = "0x29AB11C")]
	private void UpdateTeamWeaponInfo()
	{
	}

	[Token(Token = "0x600D4C5")]
	[Address(RVA = "0x29AB720", Offset = "0x29AB720", VA = "0x29AB720", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D4C6")]
	[Address(RVA = "0x2996E70", Offset = "0x2996E70", VA = "0x2996E70")]
	private void DestroyAvatar(UIMaleAvatar a)
	{
	}

	[Token(Token = "0x600D4C7")]
	[Address(RVA = "0x29AB834", Offset = "0x29AB834", VA = "0x29AB834")]
	private void OnPlayerUpdateShadowPos(object[] data)
	{
	}

	[Token(Token = "0x600D4C8")]
	[Address(RVA = "0x29AB89C", Offset = "0x29AB89C", VA = "0x29AB89C")]
	public void SetCameraEnable(bool enable)
	{
	}

	[Token(Token = "0x600D4C9")]
	[Address(RVA = "0x29A0CA0", Offset = "0x29A0CA0", VA = "0x29A0CA0")]
	private void UpdateLocalPlayerShadowPos()
	{
	}

	[Token(Token = "0x600D4CA")]
	[Address(RVA = "0x299F614", Offset = "0x299F614", VA = "0x299F614")]
	private void ShowLocalPlayerShadow(bool show)
	{
	}

	[Token(Token = "0x600D4CB")]
	[Address(RVA = "0x29AB9D4", Offset = "0x29AB9D4", VA = "0x29AB9D4")]
	private void OnLobbyVisibleChange(object[] data)
	{
	}

	[Token(Token = "0x600D4CC")]
	[Address(RVA = "0x299FB8C", Offset = "0x299FB8C", VA = "0x299FB8C")]
	private void OnPetEmoteChanged(bool isInEmote)
	{
	}

	[Token(Token = "0x600D4CD")]
	[Address(RVA = "0x29ABDA4", Offset = "0x29ABDA4", VA = "0x29ABDA4")]
	private void OnAvatarEnterGroup(object[] data)
	{
	}

	[Token(Token = "0x600D4CE")]
	[Address(RVA = "0x29ABF18", Offset = "0x29ABF18", VA = "0x29ABF18")]
	private void OnEnterGroupChangeToCaptainLobby(object[] data)
	{
	}

	[Token(Token = "0x600D4CF")]
	[Address(RVA = "0x29AC14C", Offset = "0x29AC14C", VA = "0x29AC14C")]
	private void InCaptainLobbyVFXInstant(bool isEnter)
	{
	}

	[Token(Token = "0x600D4D0")]
	[Address(RVA = "0x29AC394", Offset = "0x29AC394", VA = "0x29AC394")]
	private void HideCaptainLobbyVFXInstant(object[] data)
	{
	}

	[Token(Token = "0x600D4D1")]
	[Address(RVA = "0x29AC49C", Offset = "0x29AC49C", VA = "0x29AC49C")]
	private void LeaveCaptainLobby(object[] data)
	{
	}

	[Token(Token = "0x600D4D2")]
	[Address(RVA = "0x29AC608", Offset = "0x29AC608", VA = "0x29AC608")]
	private void OnLobbyYardEnter(object[] data)
	{
	}

	[Token(Token = "0x600D4D3")]
	[Address(RVA = "0x29AC8D4", Offset = "0x29AC8D4", VA = "0x29AC8D4")]
	private void OnHDLobbySceneItemViewEnter(object[] data)
	{
	}

	[Token(Token = "0x600D4D4")]
	[Address(RVA = "0x29AC7D4", Offset = "0x29AC7D4", VA = "0x29AC7D4")]
	private void HDResetAvatar()
	{
	}

	[Token(Token = "0x600D4D5")]
	[Address(RVA = "0x29AC9E4", Offset = "0x29AC9E4", VA = "0x29AC9E4")]
	private void OnLobbyYardVisibilityChanged(object[] data)
	{
	}

	[Token(Token = "0x600D4D6")]
	[Address(RVA = "0x29ACC68", Offset = "0x29ACC68", VA = "0x29ACC68")]
	private static UIMaleAvatar _003CCheckClothPrivilege_003Em__0(TeamAvatar o)
	{
		return null;
	}

	[Token(Token = "0x600D4D7")]
	[Address(RVA = "0x29ACC8C", Offset = "0x29ACC8C", VA = "0x29ACC8C")]
	private void _003COnProfileEnter_003Em__1()
	{
	}

	[Token(Token = "0x600D4D8")]
	[Address(RVA = "0x29ACC94", Offset = "0x29ACC94", VA = "0x29ACC94")]
	private static bool _003CFixTeammatePosID_003Em__2(int s)
	{
		return default(bool);
	}

	[Token(Token = "0x600D4D9")]
	[Address(RVA = "0x29ACCA8", Offset = "0x29ACCA8", VA = "0x29ACCA8")]
	private static bool _003CShowAvatars_003Em__3(int s)
	{
		return default(bool);
	}

	[Token(Token = "0x600D4DA")]
	[Address(RVA = "0x29ACCBC", Offset = "0x29ACCBC", VA = "0x29ACCBC")]
	private static bool _003CShowAvatars_003Em__4(int s)
	{
		return default(bool);
	}

	[Token(Token = "0x600D4DB")]
	[Address(RVA = "0x29ACCD0", Offset = "0x29ACCD0", VA = "0x29ACCD0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D4DC")]
	[Address(RVA = "0x29ACCD8", Offset = "0x29ACCD8", VA = "0x29ACCD8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
