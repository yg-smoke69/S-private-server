using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UMA;
using UnityEngine;
using UnityEngine.Rendering;

namespace COW;

[Token(Token = "0x200008B")]
public class AvatarEffect : MonoBehaviour
{
	[Token(Token = "0x200008C")]
	public enum EEffectGroup
	{
		[Token(Token = "0x4000305")]
		Default,
		[Token(Token = "0x4000306")]
		External,
		[Token(Token = "0x4000307")]
		IdleSpecial
	}

	[Token(Token = "0x200008D")]
	public enum EEffectType
	{
		[Token(Token = "0x4000309")]
		None,
		[Token(Token = "0x400030A")]
		Emotion,
		[Token(Token = "0x400030B")]
		GroupAnim,
		[Token(Token = "0x400030C")]
		Transform
	}

	[Token(Token = "0x200008E")]
	private sealed class _003CDelayPlayOutSafeZoneEffect_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x8")]
		internal float _003Cdur_003E__0;

		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0xC")]
		internal float _003Cpassed_003E__0;

		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x10")]
		internal float _003Cratio_003E__1;

		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x14")]
		internal AvatarEffect _0024this;

		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x17000082")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x234C498", Offset = "0x234C498", VA = "0x234C498", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x234C4A0", Offset = "0x234C4A0", VA = "0x234C4A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x234C18C", Offset = "0x234C18C", VA = "0x234C18C")]
		public _003CDelayPlayOutSafeZoneEffect_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x234C194", Offset = "0x234C194", VA = "0x234C194", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x234C4A8", Offset = "0x234C4A8", VA = "0x234C4A8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x234C4BC", Offset = "0x234C4BC", VA = "0x234C4BC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200008F")]
	private sealed class _003CDelayStopOutSafeZoneEffect_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x8")]
		internal float _003Cdur_003E__0;

		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0xC")]
		internal float _003Cpassed_003E__0;

		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x10")]
		internal float _003Cratio_003E__1;

		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x14")]
		internal AvatarEffect _0024this;

		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x17000084")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x234C978", Offset = "0x234C978", VA = "0x234C978", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x234C980", Offset = "0x234C980", VA = "0x234C980", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x234C544", Offset = "0x234C544", VA = "0x234C544")]
		public _003CDelayStopOutSafeZoneEffect_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x234C54C", Offset = "0x234C54C", VA = "0x234C54C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x234C988", Offset = "0x234C988", VA = "0x234C988", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x234C99C", Offset = "0x234C99C", VA = "0x234C99C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40002E5")]
	[FieldOffset(Offset = "0xC")]
	private Renderer m_renderer;

	[Token(Token = "0x40002E6")]
	[FieldOffset(Offset = "0x10")]
	private SkinnedMeshRenderer m_UMARenderer;

	[Token(Token = "0x40002E7")]
	[FieldOffset(Offset = "0x14")]
	private List<Material> m_UMARendererMat;

	[Token(Token = "0x40002E8")]
	[FieldOffset(Offset = "0x18")]
	private bool m_FindRenderFlag;

	[Token(Token = "0x40002E9")]
	[FieldOffset(Offset = "0x1C")]
	private List<int> m_avatarMatIDList;

	[Token(Token = "0x40002EA")]
	[FieldOffset(Offset = "0x20")]
	private bool m_foundSpecialEffect;

	[Token(Token = "0x40002EB")]
	[FieldOffset(Offset = "0x24")]
	private Player m_owner;

	[Token(Token = "0x40002EC")]
	[FieldOffset(Offset = "0x28")]
	private bool playingDeathEffect;

	[Token(Token = "0x40002ED")]
	[FieldOffset(Offset = "0x2C")]
	private float deathEffectTiming;

	[Token(Token = "0x40002EE")]
	[FieldOffset(Offset = "0x30")]
	private GameObject deathEffectObj;

	[Token(Token = "0x40002EF")]
	[FieldOffset(Offset = "0x34")]
	private float deathEffectDuration;

	[Token(Token = "0x40002F0")]
	[FieldOffset(Offset = "0x38")]
	private bool playingOutSafeZoneEffect;

	[Token(Token = "0x40002F1")]
	[FieldOffset(Offset = "0x3C")]
	private float outSafeZoneEffectTiming;

	[Token(Token = "0x40002F2")]
	[FieldOffset(Offset = "0x40")]
	private float outSafeZoneEffectDuration;

	[Token(Token = "0x40002F3")]
	[FieldOffset(Offset = "0x44")]
	private Texture useColorGradingTexture;

	[Token(Token = "0x40002F4")]
	[FieldOffset(Offset = "0x48")]
	private Texture useGlichTexture;

	[Token(Token = "0x40002F5")]
	[FieldOffset(Offset = "0x4C")]
	private Texture useScreenEffectTexture;

	[Token(Token = "0x40002F6")]
	[FieldOffset(Offset = "0x50")]
	public PostEffectManager postEffect;

	[Token(Token = "0x40002F7")]
	[FieldOffset(Offset = "0x54")]
	private readonly int DissolveAmount;

	[Token(Token = "0x40002F8")]
	[FieldOffset(Offset = "0x58")]
	private readonly int Enabledissolve;

	[Token(Token = "0x40002F9")]
	[FieldOffset(Offset = "0x5C")]
	private readonly int GlitchAmount;

	[Token(Token = "0x40002FA")]
	[FieldOffset(Offset = "0x60")]
	private Coroutine delayStopOutSafeZoneRoutine;

	[Token(Token = "0x40002FB")]
	[FieldOffset(Offset = "0x64")]
	private Coroutine delayPlayOutSafeZoneRoutine;

	[Token(Token = "0x40002FC")]
	[FieldOffset(Offset = "0x68")]
	private UIMaleAvatar m_LobbyAvatar;

	[Token(Token = "0x40002FD")]
	[FieldOffset(Offset = "0x6C")]
	private GameObject m_BackpackTemp;

	[Token(Token = "0x40002FE")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<int, List<GameObject>> m_AnimEffects;

	[Token(Token = "0x40002FF")]
	[FieldOffset(Offset = "0x74")]
	private List<GameObject> m_LobbyAnimList;

	[Token(Token = "0x4000300")]
	[FieldOffset(Offset = "0x78")]
	private IUmaAvatar m_Avatar;

	[Token(Token = "0x4000301")]
	[FieldOffset(Offset = "0x7C")]
	private Entity _003COwnerPlayer_003Ek__BackingField;

	[Token(Token = "0x4000302")]
	[FieldOffset(Offset = "0x80")]
	private Transform m_CachedTransform;

	[Token(Token = "0x4000303")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<GameObject> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x1700007F")]
	public IUmaAvatar Avatar
	{
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x10FFE50", Offset = "0x10FFE50", VA = "0x10FFE50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000080")]
	public Entity OwnerPlayer
	{
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x10FFF88", Offset = "0x10FFF88", VA = "0x10FFF88")]
		get
		{
			return null;
		}
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x10FF11C", Offset = "0x10FF11C", VA = "0x10FF11C")]
		set
		{
		}
	}

	[Token(Token = "0x17000081")]
	public Transform CachedTransform
	{
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x10FFF90", Offset = "0x10FFF90", VA = "0x10FFF90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x10FEE9C", Offset = "0x10FEE9C", VA = "0x10FEE9C")]
	public AvatarEffect()
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x10FEFB8", Offset = "0x10FEFB8", VA = "0x10FEFB8")]
	public void SetInGamePlayer(Entity p)
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x1100080", Offset = "0x1100080", VA = "0x1100080")]
	public void PlayFistAttack(int right)
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x11001FC", Offset = "0x11001FC", VA = "0x11001FC")]
	public void RemoveDeathEffect()
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x11009FC", Offset = "0x11009FC", VA = "0x11009FC")]
	public void PlayDeathEffect()
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x10FF124", Offset = "0x10FF124", VA = "0x10FF124")]
	public void InitOutZoneEffect()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x1101300", Offset = "0x1101300", VA = "0x1101300")]
	public void PlayOutSafeZoneEfffet()
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x1102204", Offset = "0x1102204", VA = "0x1102204")]
	private IEnumerator DelayPlayOutSafeZoneEffect()
	{
		return null;
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x11022D0", Offset = "0x11022D0", VA = "0x11022D0")]
	public void StopOutSafeZoneEfffet()
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x11027C4", Offset = "0x11027C4", VA = "0x11027C4")]
	private IEnumerator DelayStopOutSafeZoneEffect()
	{
		return null;
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x1102890", Offset = "0x1102890", VA = "0x1102890")]
	private void UpdateOutSafezoneEffect()
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x11030B4", Offset = "0x11030B4", VA = "0x11030B4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x110311C", Offset = "0x110311C", VA = "0x110311C")]
	private void UpdateDeathEffect()
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x1103708", Offset = "0x1103708", VA = "0x1103708")]
	public void PlayLobbyAnimEffect(ResourceID id)
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x1104A34", Offset = "0x1104A34", VA = "0x1104A34")]
	public void PlayEmoteAnimEffect(string ResourceIDName)
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x11068DC", Offset = "0x11068DC", VA = "0x11068DC")]
	public void PlayAnimEffectByName(string ResourceIDName)
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x1106B2C", Offset = "0x1106B2C", VA = "0x1106B2C")]
	public void PlayAnimEffect(AnimationEvent evt)
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x1107688", Offset = "0x1107688", VA = "0x1107688")]
	public void PlayAnimEffectWithPrefab(GameObject prefab)
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x1107714", Offset = "0x1107714", VA = "0x1107714")]
	public void PlayIdleAnimEffect(GameObject prefab)
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x1104DA0", Offset = "0x1104DA0", VA = "0x1104DA0")]
	public void PlayAnimEffect(GameObject prefab, EEffectGroup group, int iID = 0, EEffectType type = EEffectType.None, bool needSkip = false)
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x11038C4", Offset = "0x11038C4", VA = "0x11038C4")]
	public void PlayLobbyAnimEffect(GameObject prefab, EEffectGroup group, int iID = 0, EEffectType type = EEffectType.None, int objIdx = 0)
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x1108B1C", Offset = "0x1108B1C", VA = "0x1108B1C")]
	private void ProcessBoneNameRefsWithNoSave(GameObject go, EEffectGroup group)
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x11097C8", Offset = "0x11097C8", VA = "0x11097C8")]
	public void SetBackpackObj(GameObject obj)
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x1108088", Offset = "0x1108088", VA = "0x1108088")]
	private void ProcessBoneNameRefs(GameObject go, EEffectGroup group)
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x1107BAC", Offset = "0x1107BAC", VA = "0x1107BAC")]
	private void ProcessCastShadow(GameObject go, ShadowCastingMode shadowCastingMode)
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x1109620", Offset = "0x1109620", VA = "0x1109620")]
	public bool ScaleInLocalSpace(GameObject o)
	{
		return default(bool);
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x1109828", Offset = "0x1109828", VA = "0x1109828")]
	public bool HasEmoteEffect(EEffectGroup group = EEffectGroup.Default)
	{
		return default(bool);
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x110792C", Offset = "0x110792C", VA = "0x110792C")]
	public void ClearEffects(EEffectGroup group = EEffectGroup.Default)
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x110994C", Offset = "0x110994C", VA = "0x110994C")]
	public void ClearLobbyAnimeEffect()
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x1109B80", Offset = "0x1109B80", VA = "0x1109B80")]
	public List<GameObject> GetEffectsByType(EEffectGroup group = EEffectGroup.Default)
	{
		return null;
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x1109C70", Offset = "0x1109C70", VA = "0x1109C70")]
	public void EnableSpecialEffect(bool bEnable)
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x1109CE8", Offset = "0x1109CE8", VA = "0x1109CE8")]
	private void StartSpecialEffect()
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x110A0E0", Offset = "0x110A0E0", VA = "0x110A0E0")]
	private void StopSpecialEffect()
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x110A4B8", Offset = "0x110A4B8", VA = "0x110A4B8")]
	private void FindSpecialEffect()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x1100614", Offset = "0x1100614", VA = "0x1100614")]
	private void FindUMARendererChild(bool forceFind = false)
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x110A9E0", Offset = "0x110A9E0", VA = "0x110A9E0")]
	public void BrightnessStretchEffect(float stretchRatio)
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x110ABC0", Offset = "0x110ABC0", VA = "0x110ABC0")]
	private static bool _003CPlayAnimEffect_003Em__0(GameObject x)
	{
		return default(bool);
	}
}
