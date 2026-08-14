using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x20003E1")]
internal class NewPlayerAnimationSystemComponent : AnimationSystemComponent
{
	[Token(Token = "0x20003E2")]
	private sealed class PJDNJLIHKLK : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400397E")]
		[FieldOffset(Offset = "0x8")]
		internal GameMiscConfig GPMLCLLCBFF;

		[Token(Token = "0x400397F")]
		[FieldOffset(Offset = "0xC")]
		internal float PGPEANBJJPN;

		[Token(Token = "0x4003980")]
		[FieldOffset(Offset = "0x10")]
		internal float FICLFGKFBHH;

		[Token(Token = "0x4003981")]
		[FieldOffset(Offset = "0x14")]
		internal float JGFAFFFCONE;

		[Token(Token = "0x4003982")]
		[FieldOffset(Offset = "0x18")]
		internal NewPlayerAnimationSystemComponent GADHAMJEKIM;

		[Token(Token = "0x4003983")]
		[FieldOffset(Offset = "0x1C")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x4003984")]
		[FieldOffset(Offset = "0x20")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x4003985")]
		[FieldOffset(Offset = "0x24")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x170001A6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60011E9")]
			[Address(RVA = "0x18A4574", Offset = "0x18A4574", VA = "0x18A4574", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60011EA")]
			[Address(RVA = "0x18A457C", Offset = "0x18A457C", VA = "0x18A457C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60011E7")]
		[Address(RVA = "0x18A3F30", Offset = "0x18A3F30", VA = "0x18A3F30")]
		public PJDNJLIHKLK()
		{
		}

		[Token(Token = "0x60011E8")]
		[Address(RVA = "0x18A3F38", Offset = "0x18A3F38", VA = "0x18A3F38", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60011EB")]
		[Address(RVA = "0x18A4584", Offset = "0x18A4584", VA = "0x18A4584", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60011EC")]
		[Address(RVA = "0x18A4598", Offset = "0x18A4598", VA = "0x18A4598", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20003E3")]
	private sealed class MNDHBGELIEM : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4003986")]
		[FieldOffset(Offset = "0x8")]
		internal NewPlayerAnimationSystemComponent GADHAMJEKIM;

		[Token(Token = "0x4003987")]
		[FieldOffset(Offset = "0xC")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x4003988")]
		[FieldOffset(Offset = "0x10")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x4003989")]
		[FieldOffset(Offset = "0x14")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x170001A8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60011EF")]
			[Address(RVA = "0x18A3E84", Offset = "0x18A3E84", VA = "0x18A3E84", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60011F0")]
			[Address(RVA = "0x18A3E8C", Offset = "0x18A3E8C", VA = "0x18A3E8C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60011ED")]
		[Address(RVA = "0x18A3DD0", Offset = "0x18A3DD0", VA = "0x18A3DD0")]
		public MNDHBGELIEM()
		{
		}

		[Token(Token = "0x60011EE")]
		[Address(RVA = "0x18A3DD8", Offset = "0x18A3DD8", VA = "0x18A3DD8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60011F1")]
		[Address(RVA = "0x18A3E94", Offset = "0x18A3E94", VA = "0x18A3E94", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60011F2")]
		[Address(RVA = "0x18A3EA8", Offset = "0x18A3EA8", VA = "0x18A3EA8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400395A")]
	[FieldOffset(Offset = "0x28")]
	private bool MHKGLFFJNFE;

	[Token(Token = "0x400395B")]
	[FieldOffset(Offset = "0x29")]
	private bool JIHMLGAPPJC;

	[Token(Token = "0x400395C")]
	[FieldOffset(Offset = "0x2C")]
	protected Player AFFLMOEAHKC;

	[Token(Token = "0x400395D")]
	[FieldOffset(Offset = "0x30")]
	private float BLAELIIOCIO;

	[Token(Token = "0x400395E")]
	[FieldOffset(Offset = "0x34")]
	private bool JBGOKFHDOJA;

	[Token(Token = "0x400395F")]
	private const string OBGPLNLIDGN = "CustomAnim";

	[Token(Token = "0x4003960")]
	private const string CPBAABENDIE = "OnChair";

	[Token(Token = "0x4003961")]
	private const string IHBDOHEPEDH = "PartyDance";

	[Token(Token = "0x4003962")]
	private const string DHKENAGKBPA = "FreezeEmote";

	[Token(Token = "0x4003963")]
	private const string ECBMANFPNDD = "EmoteIdle";

	[Token(Token = "0x4003964")]
	[FieldOffset(Offset = "0x38")]
	private AnimRef POLBMKMKAEM;

	[Token(Token = "0x4003965")]
	[FieldOffset(Offset = "0x3C")]
	private bool AKJDFBEHDII;

	[Token(Token = "0x4003966")]
	[FieldOffset(Offset = "0x3D")]
	private bool NPCKMFMGPKD;

	[Token(Token = "0x4003967")]
	[FieldOffset(Offset = "0x40")]
	private AnimatorOverrideController DGJFDGIDNDA;

	[Token(Token = "0x4003968")]
	[FieldOffset(Offset = "0x44")]
	private int GLICILOJCCI;

	[Token(Token = "0x4003969")]
	[FieldOffset(Offset = "0x0")]
	public static List<AnimationClip> MaleDynamicClips;

	[Token(Token = "0x400396A")]
	[FieldOffset(Offset = "0x4")]
	public static List<AnimationClip> FemaleDynamicClips;

	[Token(Token = "0x400396B")]
	[FieldOffset(Offset = "0x8")]
	private static readonly bool IHNAELBNLCG;

	[Token(Token = "0x400396C")]
	[FieldOffset(Offset = "0xC")]
	private static Dictionary<string, int> DPDGCOGEKJE;

	[Token(Token = "0x400396D")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<string, int> FLAJLMMKNBE;

	[Token(Token = "0x400396E")]
	[FieldOffset(Offset = "0x14")]
	public static List<KeyValuePair<int, int>> s_DynamicClipMappingsMale;

	[Token(Token = "0x400396F")]
	[FieldOffset(Offset = "0x18")]
	public static List<KeyValuePair<int, int>> s_DynamicClipMappingsFemale;

	[Token(Token = "0x4003970")]
	[FieldOffset(Offset = "0x1C")]
	private static List<KeyValuePair<AnimationClip, AnimationClip>> AJHNDHBIKKA;

	[Token(Token = "0x4003971")]
	[FieldOffset(Offset = "0x20")]
	private static List<KeyValuePair<AnimationClip, AnimationClip>> MKPGDIGCHLG;

	[Token(Token = "0x4003972")]
	[FieldOffset(Offset = "0x24")]
	private static AnimatorOverrideController JMAMAKKOJLN;

	[Token(Token = "0x4003973")]
	[FieldOffset(Offset = "0x28")]
	private static AnimatorOverrideController HOGACMCGIMN;

	[Token(Token = "0x4003974")]
	[FieldOffset(Offset = "0x2C")]
	private static int LFFCHCBLDEM;

	[Token(Token = "0x4003975")]
	[FieldOffset(Offset = "0x30")]
	private static int CPJJKJCDHNK;

	[Token(Token = "0x4003976")]
	[FieldOffset(Offset = "0x48")]
	protected float NIPPBMDNNII;

	[Token(Token = "0x4003977")]
	[FieldOffset(Offset = "0x4C")]
	private bool AIIIFMLDILN;

	[Token(Token = "0x4003978")]
	[FieldOffset(Offset = "0x50")]
	private float HOCLBPAAIBB;

	[Token(Token = "0x4003979")]
	[FieldOffset(Offset = "0x54")]
	private float EIBLCINPBDI;

	[Token(Token = "0x400397A")]
	[FieldOffset(Offset = "0x58")]
	private float EDPPHIBDGLM;

	[Token(Token = "0x400397B")]
	[FieldOffset(Offset = "0x5C")]
	private bool GAJPGGKCEGB;

	[Token(Token = "0x400397C")]
	[FieldOffset(Offset = "0x60")]
	private float EKPIMAJOCJC;

	[Token(Token = "0x400397D")]
	[FieldOffset(Offset = "0x64")]
	private float PDLFMDMMGIB;

	[Token(Token = "0x170001A1")]
	private bool GPHCCDLNALP
	{
		[Token(Token = "0x600116F")]
		[Address(RVA = "0x17F960C", Offset = "0x17F960C", VA = "0x17F960C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001A2")]
	public bool OBIPKMDDMBN
	{
		[Token(Token = "0x6001170")]
		[Address(RVA = "0x17F9834", Offset = "0x17F9834", VA = "0x17F9834")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001171")]
		[Address(RVA = "0x17F96E4", Offset = "0x17F96E4", VA = "0x17F96E4")]
		set
		{
		}
	}

	[Token(Token = "0x170001A3")]
	public bool BHPDGKDABHI
	{
		[Token(Token = "0x600117E")]
		[Address(RVA = "0x17FB720", Offset = "0x17FB720", VA = "0x17FB720")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001A4")]
	public float JHLMADMLIEP
	{
		[Token(Token = "0x60011A8")]
		[Address(RVA = "0x1800DA4", Offset = "0x1800DA4", VA = "0x1800DA4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170001A5")]
	private AnimatorOverrideController KGCOBNHALNC
	{
		[Token(Token = "0x60011C9")]
		[Address(RVA = "0x1806334", Offset = "0x1806334", VA = "0x1806334")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600116B")]
	[Address(RVA = "0x17F8F5C", Offset = "0x17F8F5C", VA = "0x17F8F5C")]
	public NewPlayerAnimationSystemComponent()
	{
	}

	[Token(Token = "0x600116C")]
	[Address(RVA = "0x17F9010", Offset = "0x17F9010", VA = "0x17F9010")]
	public void ResetAnimationSpeed()
	{
	}

	[Token(Token = "0x600116D")]
	[Address(RVA = "0x17F909C", Offset = "0x17F909C", VA = "0x17F909C")]
	public void SetAnimationSpeed(float OJGNBJELDEM)
	{
	}

	[Token(Token = "0x600116E")]
	[Address(RVA = "0x17F9144", Offset = "0x17F9144", VA = "0x17F9144", Slot = "12")]
	public virtual void Init(Player FIMNKGABILM)
	{
	}

	[Token(Token = "0x6001172")]
	[Address(RVA = "0x17F988C", Offset = "0x17F988C", VA = "0x17F988C")]
	public AnimationRuntimeHandle PlayCustomAnim(ResourceID KMIPBIGPDPI, bool ANDPBKOAIKH = false, float KPCJADGMEJG = 0f)
	{
		return null;
	}

	[Token(Token = "0x6001173")]
	[Address(RVA = "0x17F9C24", Offset = "0x17F9C24", VA = "0x17F9C24")]
	public void PlayFreezeCustomAnim(ResourceID OPOPKGJLIGP, ResourceID CHFGJGAJNGO)
	{
	}

	[Token(Token = "0x6001174")]
	[Address(RVA = "0x17F9EC8", Offset = "0x17F9EC8", VA = "0x17F9EC8")]
	public void PlayPartyDance(ResourceID KMIPBIGPDPI, float JOMKIGFPPGD = 0f)
	{
	}

	[Token(Token = "0x6001175")]
	[Address(RVA = "0x17FA1A4", Offset = "0x17FA1A4", VA = "0x17FA1A4")]
	public void PlaySitting()
	{
	}

	[Token(Token = "0x6001176")]
	[Address(RVA = "0x17F9A94", Offset = "0x17F9A94", VA = "0x17F9A94")]
	private void LJNJJDAFGLH(string MBOCHECKLMJ, AnimRef DIENGEMMHFF)
	{
	}

	[Token(Token = "0x6001177")]
	[Address(RVA = "0x17FA460", Offset = "0x17FA460", VA = "0x17FA460")]
	private AnimatorOverrideController AAPALMAAEMB(string MBOCHECKLMJ, AnimationClip MBAGEFEJDOA)
	{
		return null;
	}

	[Token(Token = "0x6001178")]
	[Address(RVA = "0x17FAE40", Offset = "0x17FAE40", VA = "0x17FAE40")]
	public float GetCurrentAnimationnNormalizedTime()
	{
		return default(float);
	}

	[Token(Token = "0x6001179")]
	[Address(RVA = "0x17FAF08", Offset = "0x17FAF08", VA = "0x17FAF08")]
	public float GetCurrentAnimationLength()
	{
		return default(float);
	}

	[Token(Token = "0x600117A")]
	[Address(RVA = "0x17FB068", Offset = "0x17FB068", VA = "0x17FB068")]
	public void PlayBeginCreep(FBCAHNCLMDC LLNHEMJJNGF)
	{
	}

	[Token(Token = "0x600117B")]
	[Address(RVA = "0x17FB274", Offset = "0x17FB274", VA = "0x17FB274")]
	public bool IsDuringCreep()
	{
		return default(bool);
	}

	[Token(Token = "0x600117C")]
	[Address(RVA = "0x17FB4DC", Offset = "0x17FB4DC", VA = "0x17FB4DC")]
	public void PlayEndCreep(FBCAHNCLMDC JDDIEPOJPKL)
	{
	}

	[Token(Token = "0x600117D")]
	[Address(RVA = "0x17FB63C", Offset = "0x17FB63C", VA = "0x17FB63C")]
	private bool KAPHFJOPEPF()
	{
		return default(bool);
	}

	[Token(Token = "0x600117F")]
	[Address(RVA = "0x17FB778", Offset = "0x17FB778", VA = "0x17FB778", Slot = "13")]
	public virtual void PlayFireAnim()
	{
	}

	[Token(Token = "0x6001180")]
	[Address(RVA = "0x17FBBA4", Offset = "0x17FBBA4", VA = "0x17FBBA4")]
	public void PlayStopFire()
	{
	}

	[Token(Token = "0x6001181")]
	[Address(RVA = "0x17FBDEC", Offset = "0x17FBDEC", VA = "0x17FBDEC", Slot = "14")]
	public virtual void PlayReloadAnim(float MLPAAKNGDLA = 1f)
	{
	}

	[Token(Token = "0x6001182")]
	[Address(RVA = "0x17FC108", Offset = "0x17FC108", VA = "0x17FC108")]
	public void PlayFallingLandAnim(float FCIEILOOMOD = 1f)
	{
	}

	[Token(Token = "0x6001183")]
	[Address(RVA = "0x17FC254", Offset = "0x17FC254", VA = "0x17FC254", Slot = "15")]
	public virtual void PlayChangeWeaponAnim(GPBDEDFKJNA LPLPBJGAPHK, float OJGNBJELDEM = 1f)
	{
	}

	[Token(Token = "0x6001184")]
	[Address(RVA = "0x17FC500", Offset = "0x17FC500", VA = "0x17FC500")]
	public void PlayStartSkyDiving(bool GKDIBCKHHFC)
	{
	}

	[Token(Token = "0x6001185")]
	[Address(RVA = "0x17FC674", Offset = "0x17FC674", VA = "0x17FC674")]
	public void PlayStartFlightSkyDiving(bool GKDIBCKHHFC)
	{
	}

	[Token(Token = "0x6001186")]
	[Address(RVA = "0x17FC7E8", Offset = "0x17FC7E8", VA = "0x17FC7E8")]
	public void PlayStartFlightParachuting(bool INMJCOKOMDP)
	{
	}

	[Token(Token = "0x6001187")]
	[Address(RVA = "0x17FC95C", Offset = "0x17FC95C", VA = "0x17FC95C")]
	public void PlayStartSkyDriving(bool INMJCOKOMDP)
	{
	}

	[Token(Token = "0x6001188")]
	[Address(RVA = "0x17FCAD0", Offset = "0x17FCAD0", VA = "0x17FCAD0")]
	public void PlayStartSkySurfing(bool INMJCOKOMDP)
	{
	}

	[Token(Token = "0x6001189")]
	[Address(RVA = "0x17FCC44", Offset = "0x17FCC44", VA = "0x17FCC44")]
	public void PlayStartParachuting()
	{
	}

	[Token(Token = "0x600118A")]
	[Address(RVA = "0x17FCD50", Offset = "0x17FCD50", VA = "0x17FCD50")]
	public void PlayStartSwimming(Player.DFKKGHCFGNM DLECPMBKMKM)
	{
	}

	[Token(Token = "0x600118B")]
	[Address(RVA = "0x17FCEB0", Offset = "0x17FCEB0", VA = "0x17FCEB0")]
	public void PlaySwimmingToSurf()
	{
	}

	[Token(Token = "0x600118C")]
	[Address(RVA = "0x17FCFBC", Offset = "0x17FCFBC", VA = "0x17FCFBC")]
	public void PlayJump(bool DMLAMMGKOMP = false)
	{
	}

	[Token(Token = "0x600118D")]
	[Address(RVA = "0x17FD0D0", Offset = "0x17FD0D0", VA = "0x17FD0D0")]
	public void PlaySecondJump()
	{
	}

	[Token(Token = "0x600118E")]
	[Address(RVA = "0x17FD1DC", Offset = "0x17FD1DC", VA = "0x17FD1DC")]
	public void PlayHitAnimation()
	{
	}

	[Token(Token = "0x600118F")]
	[Address(RVA = "0x17FD50C", Offset = "0x17FD50C", VA = "0x17FD50C")]
	public void PlayDead(bool KCHNLMEEHOP, GKJKKIMIMHE CECACOBDFEP = GKJKKIMIMHE.DEAD_ANIM_DIR_FRONT)
	{
	}

	[Token(Token = "0x6001190")]
	[Address(RVA = "0x17FDBC4", Offset = "0x17FDBC4", VA = "0x17FDBC4")]
	private IEnumerator OAOKMMNAHLF()
	{
		return null;
	}

	[Token(Token = "0x6001191")]
	[Address(RVA = "0x17FDC90", Offset = "0x17FDC90", VA = "0x17FDC90")]
	public void SetDeadAnimation()
	{
	}

	[Token(Token = "0x6001192")]
	[Address(RVA = "0x17FDDA0", Offset = "0x17FDDA0", VA = "0x17FDDA0")]
	public void PlayCureAnimation(bool FJNDHBCJPEJ)
	{
	}

	[Token(Token = "0x6001193")]
	[Address(RVA = "0x17FE170", Offset = "0x17FE170", VA = "0x17FE170")]
	public void PlayEatMushRoomAnimation(bool FJNDHBCJPEJ)
	{
	}

	[Token(Token = "0x6001194")]
	[Address(RVA = "0x17FE540", Offset = "0x17FE540", VA = "0x17FE540")]
	public void PlayRepairingAnimation(bool FJNDHBCJPEJ)
	{
	}

	[Token(Token = "0x6001195")]
	[Address(RVA = "0x17FEB10", Offset = "0x17FEB10", VA = "0x17FEB10")]
	public void PlayBatteryAnimation(bool FJNDHBCJPEJ)
	{
	}

	[Token(Token = "0x6001196")]
	[Address(RVA = "0x17FEEE0", Offset = "0x17FEEE0", VA = "0x17FEEE0")]
	public void PlayPreparationAnimation(bool FJNDHBCJPEJ)
	{
	}

	[Token(Token = "0x6001197")]
	[Address(RVA = "0x17FF4B0", Offset = "0x17FF4B0", VA = "0x17FF4B0", Slot = "16")]
	public virtual void PlayTriggerGrenade()
	{
	}

	[Token(Token = "0x6001198")]
	[Address(RVA = "0x17FF62C", Offset = "0x17FF62C", VA = "0x17FF62C", Slot = "17")]
	public virtual void PlayStartGrenade(bool FJNDHBCJPEJ)
	{
	}

	[Token(Token = "0x6001199")]
	[Address(RVA = "0x17FFA0C", Offset = "0x17FFA0C", VA = "0x17FFA0C", Slot = "18")]
	public virtual void PlayStartThrowKnife(bool FJNDHBCJPEJ)
	{
	}

	[Token(Token = "0x600119A")]
	[Address(RVA = "0x17FFDEC", Offset = "0x17FFDEC", VA = "0x17FFDEC")]
	public void PlayPullBolt(float CJPFFCPKJLD = 1f)
	{
	}

	[Token(Token = "0x600119B")]
	[Address(RVA = "0x1800020", Offset = "0x1800020", VA = "0x1800020")]
	public void PlaySkateboard()
	{
	}

	[Token(Token = "0x600119C")]
	[Address(RVA = "0x18001D0", Offset = "0x18001D0", VA = "0x18001D0")]
	public void PlaySkateboardDash()
	{
	}

	[Token(Token = "0x600119D")]
	[Address(RVA = "0x18002DC", Offset = "0x18002DC", VA = "0x18002DC")]
	public void PlaySkateboardJump()
	{
	}

	[Token(Token = "0x600119E")]
	[Address(RVA = "0x18003E8", Offset = "0x18003E8", VA = "0x18003E8")]
	public void PlaySkateboardLand(float FCIEILOOMOD = 1f)
	{
	}

	[Token(Token = "0x600119F")]
	[Address(RVA = "0x1800534", Offset = "0x1800534", VA = "0x1800534")]
	public void SetParachutingSpeed(float LGBDNJEHFMB, float INEJHIDOPDE)
	{
	}

	[Token(Token = "0x60011A0")]
	[Address(RVA = "0x18006C8", Offset = "0x18006C8", VA = "0x18006C8")]
	public void SetJetFlySpeed(float LGBDNJEHFMB, float INEJHIDOPDE)
	{
	}

	[Token(Token = "0x60011A1")]
	[Address(RVA = "0x18007E4", Offset = "0x18007E4", VA = "0x18007E4")]
	public void SetSkydivingSpeed(float INEJHIDOPDE)
	{
	}

	[Token(Token = "0x60011A2")]
	[Address(RVA = "0x1800930", Offset = "0x1800930", VA = "0x1800930")]
	public void SetSkysurfingSpeed(float INEJHIDOPDE)
	{
	}

	[Token(Token = "0x60011A3")]
	[Address(RVA = "0x1800A7C", Offset = "0x1800A7C", VA = "0x1800A7C")]
	public void SetFlightRoamSpeed(float LGBDNJEHFMB, float INEJHIDOPDE)
	{
	}

	[Token(Token = "0x60011A4")]
	[Address(RVA = "0x1800B98", Offset = "0x1800B98", VA = "0x1800B98", Slot = "19")]
	public virtual void GetOnVehicle(int ACCOJJMKKPM)
	{
	}

	[Token(Token = "0x60011A5")]
	[Address(RVA = "0x1800CDC", Offset = "0x1800CDC", VA = "0x1800CDC", Slot = "20")]
	public virtual void GetOffVehicle()
	{
	}

	[Token(Token = "0x60011A6")]
	[Address(RVA = "0x1800C0C", Offset = "0x1800C0C", VA = "0x1800C0C")]
	private void NADCPFNLGFI(float ACCOJJMKKPM)
	{
	}

	[Token(Token = "0x60011A7")]
	[Address(RVA = "0x1800D40", Offset = "0x1800D40", VA = "0x1800D40", Slot = "21")]
	public virtual float ClampForwardSpeed(float NLDLLCIMJGH)
	{
		return default(float);
	}

	[Token(Token = "0x60011A9")]
	[Address(RVA = "0x1800DFC", Offset = "0x1800DFC", VA = "0x1800DFC", Slot = "22")]
	public virtual void SetSpeed(float LGBDNJEHFMB, float INEJHIDOPDE, bool HMGHCCGHFML = false)
	{
	}

	[Token(Token = "0x60011AA")]
	[Address(RVA = "0x180167C", Offset = "0x180167C", VA = "0x180167C")]
	public void SetInShoal(bool IMLJCHMOIFP)
	{
	}

	[Token(Token = "0x60011AB")]
	[Address(RVA = "0x180178C", Offset = "0x180178C", VA = "0x180178C")]
	public void UpdateAnimSpeed(float OJGNBJELDEM)
	{
	}

	[Token(Token = "0x60011AC")]
	[Address(RVA = "0x18018C8", Offset = "0x18018C8", VA = "0x18018C8")]
	public void SetVehicleSteeringAngle(float BLHEBBCODLC)
	{
	}

	[Token(Token = "0x60011AD")]
	[Address(RVA = "0x1801998", Offset = "0x1801998", VA = "0x1801998")]
	public void SetHasDriver(float BLHEBBCODLC)
	{
	}

	[Token(Token = "0x60011AE")]
	[Address(RVA = "0x17FBD08", Offset = "0x17FBD08", VA = "0x17FBD08")]
	public void RefreshBaseLayerDefaultState()
	{
	}

	[Token(Token = "0x60011AF")]
	[Address(RVA = "0x1801A68", Offset = "0x1801A68", VA = "0x1801A68")]
	public void ResetToAnimatorDefaultState()
	{
	}

	[Token(Token = "0x60011B0")]
	[Address(RVA = "0x1801BEC", Offset = "0x1801BEC", VA = "0x1801BEC")]
	public void UpdateSpeedScale(float AFLMPELGFDF)
	{
	}

	[Token(Token = "0x60011B1")]
	[Address(RVA = "0x1801DC8", Offset = "0x1801DC8", VA = "0x1801DC8")]
	public void SwitchWeaponAnimController(AnimatorOverrideController DMKBBAIDGDA)
	{
	}

	[Token(Token = "0x60011B2")]
	[Address(RVA = "0x1802424", Offset = "0x1802424", VA = "0x1802424")]
	private void LBNANBKDIID(AnimatorOverrideController GJAEIAPCPMP)
	{
	}

	[Token(Token = "0x60011B3")]
	[Address(RVA = "0x18024A0", Offset = "0x18024A0", VA = "0x18024A0", Slot = "6")]
	public override void SwitchAnimController(RuntimeAnimatorController OAKCAOBNEPH)
	{
	}

	[Token(Token = "0x60011B4")]
	[Address(RVA = "0x180251C", Offset = "0x180251C", VA = "0x180251C", Slot = "4")]
	protected override uint GetMaxLayerUsed()
	{
		return default(uint);
	}

	[Token(Token = "0x60011B5")]
	[Address(RVA = "0x18025F4", Offset = "0x18025F4", VA = "0x18025F4", Slot = "7")]
	protected override void BeforeTransitionToDefaultStateAfterFinish()
	{
	}

	[Token(Token = "0x60011B6")]
	[Address(RVA = "0x1802714", Offset = "0x1802714", VA = "0x1802714", Slot = "8")]
	protected override void OnTransitionToDefaultState(int PFMKMEONOCH)
	{
	}

	[Token(Token = "0x60011B7")]
	[Address(RVA = "0x1802E00", Offset = "0x1802E00", VA = "0x1802E00")]
	private void PAFHJPLGEGH()
	{
	}

	[Token(Token = "0x60011B8")]
	[Address(RVA = "0x1803EBC", Offset = "0x1803EBC", VA = "0x1803EBC", Slot = "10")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60011B9")]
	[Address(RVA = "0x1803F50", Offset = "0x1803F50", VA = "0x1803F50")]
	public bool GetNeedUpdateValue()
	{
		return default(bool);
	}

	[Token(Token = "0x60011BA")]
	[Address(RVA = "0x1803FA8", Offset = "0x1803FA8", VA = "0x1803FA8")]
	public void SetAnimatorCullingMode(AnimatorCullingMode OAFPKNHMBBD)
	{
	}

	[Token(Token = "0x60011BB")]
	[Address(RVA = "0x180402C", Offset = "0x180402C", VA = "0x180402C")]
	public void ReSetAnimatorCullingMode()
	{
	}

	[Token(Token = "0x60011BC")]
	[Address(RVA = "0x18040AC", Offset = "0x18040AC", VA = "0x18040AC", Slot = "11")]
	public override void EnableAnimator(bool JBPPGEAJPNL)
	{
	}

	[Token(Token = "0x60011BD")]
	[Address(RVA = "0x1804140", Offset = "0x1804140", VA = "0x1804140")]
	public void Tick(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60011BE")]
	[Address(RVA = "0x180473C", Offset = "0x180473C", VA = "0x180473C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60011BF")]
	[Address(RVA = "0x1804304", Offset = "0x1804304", VA = "0x1804304")]
	public void UpdateAnimator(bool DPEBBLGPIMH = false)
	{
	}

	[Token(Token = "0x60011C0")]
	[Address(RVA = "0x180488C", Offset = "0x180488C", VA = "0x180488C")]
	public void ForceUpdateAnimator()
	{
	}

	[Token(Token = "0x60011C1")]
	protected override T PlayAnimInternal<T>(AnimationConfigData AJKBOONEOAB, bool FJMIBOFFNNG, float OCJOEHIOFHJ = 0f, bool ANDPBKOAIKH = false)
	{
		return null;
	}

	[Token(Token = "0x60011C2")]
	[Address(RVA = "0x1804B00", Offset = "0x1804B00", VA = "0x1804B00", Slot = "5")]
	public override AnimationRuntimeHandle PlayAnim(AnimationID MFNEABEJJCB, bool IGKOOPCGEGE = false, float COEGAOBAMLE = 0f, bool FJMIBOFFNNG = false, bool ANDPBKOAIKH = false)
	{
		return null;
	}

	[Token(Token = "0x60011C3")]
	[Address(RVA = "0x18057A8", Offset = "0x18057A8", VA = "0x18057A8")]
	public static void ReleaseStaticResources()
	{
	}

	[Token(Token = "0x60011C4")]
	[Address(RVA = "0x1805A94", Offset = "0x1805A94", VA = "0x1805A94")]
	public void Clear()
	{
	}

	[Token(Token = "0x60011C5")]
	[Address(RVA = "0x1805B28", Offset = "0x1805B28", VA = "0x1805B28")]
	public bool IsEmoteAnim(AnimationID MFNEABEJJCB)
	{
		return default(bool);
	}

	[Token(Token = "0x60011C6")]
	[Address(RVA = "0x1805CD4", Offset = "0x1805CD4", VA = "0x1805CD4")]
	public void BindTransformerAnimator(Animator GHEAAGPHBMM)
	{
	}

	[Token(Token = "0x60011C7")]
	[Address(RVA = "0x18060BC", Offset = "0x18060BC", VA = "0x18060BC")]
	private IEnumerator OMEFIEJDDCG()
	{
		return null;
	}

	[Token(Token = "0x60011C8")]
	[Address(RVA = "0x1806188", Offset = "0x1806188", VA = "0x1806188")]
	public void ClearAnimatorCache()
	{
	}

	[Token(Token = "0x60011CA")]
	[Address(RVA = "0x180642C", Offset = "0x180642C", VA = "0x180642C")]
	private AnimatorOverrideController FNIKPJHELJL()
	{
		return null;
	}

	[Token(Token = "0x60011CB")]
	[Address(RVA = "0x18065F0", Offset = "0x18065F0", VA = "0x18065F0")]
	private AnimatorOverrideController COEMPGBCKLA()
	{
		return null;
	}

	[Token(Token = "0x60011CC")]
	[Address(RVA = "0x17FAAB8", Offset = "0x17FAAB8", VA = "0x17FAAB8")]
	private AnimatorOverrideController MFLHKCGKILO(string MBOCHECKLMJ, AnimationClip MBAGEFEJDOA)
	{
		return null;
	}

	[Token(Token = "0x60011CD")]
	[Address(RVA = "0x1805490", Offset = "0x1805490", VA = "0x1805490")]
	private void OCGNHFJEBII(AnimationID MFNEABEJJCB)
	{
	}

	[Token(Token = "0x60011CE")]
	[Address(RVA = "0x1806804", Offset = "0x1806804", VA = "0x1806804")]
	private void EJIFOHDGMPK(List<string[]> IOPEKJFAKIA, AnimationID MFNEABEJJCB)
	{
	}

	[Token(Token = "0x60011CF")]
	[Address(RVA = "0x1806F3C", Offset = "0x1806F3C", VA = "0x1806F3C")]
	private void BHKMPPOMKFH(List<AnimRef> NICDHEJIPAK, AnimationID DJLBNJEJJLN)
	{
	}

	[Token(Token = "0x60011D0")]
	[Address(RVA = "0x1807054", Offset = "0x1807054", VA = "0x1807054")]
	private bool DAABDHFFKAK(List<AnimRef> NICDHEJIPAK, AnimatorOverrideController GJAEIAPCPMP)
	{
		return default(bool);
	}

	[Token(Token = "0x60011D1")]
	[Address(RVA = "0x18073F0", Offset = "0x18073F0", VA = "0x18073F0")]
	private void OCGNHFJEBII(AnimationClip CEHEKGILEJM)
	{
	}

	[Token(Token = "0x60011D2")]
	[Address(RVA = "0x18072A0", Offset = "0x18072A0", VA = "0x18072A0")]
	private bool PJFGOFKBPDP(AnimatorOverrideController DJPMPBPLAIP)
	{
		return default(bool);
	}

	[Token(Token = "0x60011D3")]
	[Address(RVA = "0x18076A4", Offset = "0x18076A4", VA = "0x18076A4")]
	private bool PJFGOFKBPDP(List<AnimationClip> JBONACJLNOO, AnimatorOverrideController DJPMPBPLAIP)
	{
		return default(bool);
	}

	[Token(Token = "0x60011D4")]
	[Address(RVA = "0x180211C", Offset = "0x180211C", VA = "0x180211C")]
	private AnimatorOverrideController BOGBMBBGDAF(AnimatorOverrideController DMKBBAIDGDA)
	{
		return null;
	}

	[Token(Token = "0x60011D5")]
	[Address(RVA = "0x17FA50C", Offset = "0x17FA50C", VA = "0x17FA50C")]
	private AnimatorOverrideController HLMNINPLBJH(string MBOCHECKLMJ, AnimationClip MBAGEFEJDOA)
	{
		return null;
	}

	[Token(Token = "0x60011D6")]
	[Address(RVA = "0x1804D9C", Offset = "0x1804D9C", VA = "0x1804D9C")]
	private void MOJJJMEEGKE(AnimationID MFNEABEJJCB)
	{
	}

	[Token(Token = "0x60011D7")]
	[Address(RVA = "0x1801F10", Offset = "0x1801F10", VA = "0x1801F10")]
	private AnimatorOverrideController GLMHLCBMLDD(AnimatorOverrideController CFLMOENJLGN)
	{
		return null;
	}

	[Token(Token = "0x60011D8")]
	[Address(RVA = "0x1808FF8", Offset = "0x1808FF8", VA = "0x1808FF8")]
	private List<AnimationClip> PFEIGNDIKAL()
	{
		return null;
	}

	[Token(Token = "0x60011D9")]
	[Address(RVA = "0x1807964", Offset = "0x1807964", VA = "0x1807964")]
	private AnimatorOverrideController EDNGHMBCBFJ(List<KeyValuePair<AnimationClip, AnimationClip>> DILFNNOLBMF)
	{
		return null;
	}

	[Token(Token = "0x60011DA")]
	[Address(RVA = "0x1807BD0", Offset = "0x1807BD0", VA = "0x1807BD0")]
	private void BLHJOEHPBBE(List<KeyValuePair<AnimationClip, AnimationClip>> DILFNNOLBMF)
	{
	}

	[Token(Token = "0x60011DB")]
	[Address(RVA = "0x1809134", Offset = "0x1809134", VA = "0x1809134")]
	private void BLHJOEHPBBE(ref AnimatorOverrideController EGEMKEKFCCB, List<KeyValuePair<AnimationClip, AnimationClip>> DILFNNOLBMF)
	{
	}

	[Token(Token = "0x60011DC")]
	[Address(RVA = "0x1808A3C", Offset = "0x1808A3C", VA = "0x1808A3C")]
	private void KOINOCEEPCL(bool HHCCBKKFCLJ, ref int GDCHBKGDLED, string[] CMKFPNFMNFA)
	{
	}

	[Token(Token = "0x60011DD")]
	[Address(RVA = "0x1807D6C", Offset = "0x1807D6C", VA = "0x1807D6C")]
	private void EGMHAKFAIEH(List<KeyValuePair<AnimationClip, AnimationClip>> FPLFDIOMCPD, bool LEFKDLCLDLK)
	{
	}

	[Token(Token = "0x60011DE")]
	[Address(RVA = "0x1808924", Offset = "0x1808924", VA = "0x1808924")]
	private void DFFOEOOAFGE(List<KeyValuePair<AnimationClip, AnimationClip>> DILFNNOLBMF)
	{
	}

	[Token(Token = "0x60011E0")]
	[Address(RVA = "0x1809434", Offset = "0x1809434", VA = "0x1809434")]
	public void _003C_003EiFixBaseProxy_SwitchAnimController(RuntimeAnimatorController P0)
	{
	}

	[Token(Token = "0x60011E1")]
	[Address(RVA = "0x180943C", Offset = "0x180943C", VA = "0x180943C")]
	public uint _003C_003EiFixBaseProxy_GetMaxLayerUsed()
	{
		return default(uint);
	}

	[Token(Token = "0x60011E2")]
	[Address(RVA = "0x1809444", Offset = "0x1809444", VA = "0x1809444")]
	public void _003C_003EiFixBaseProxy_BeforeTransitionToDefaultStateAfterFinish()
	{
	}

	[Token(Token = "0x60011E3")]
	[Address(RVA = "0x180944C", Offset = "0x180944C", VA = "0x180944C")]
	public void _003C_003EiFixBaseProxy_OnTransitionToDefaultState(int P0)
	{
	}

	[Token(Token = "0x60011E4")]
	[Address(RVA = "0x1809454", Offset = "0x1809454", VA = "0x1809454")]
	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	[Token(Token = "0x60011E5")]
	[Address(RVA = "0x180945C", Offset = "0x180945C", VA = "0x180945C")]
	public void _003C_003EiFixBaseProxy_EnableAnimator(bool P0)
	{
	}

	[Token(Token = "0x60011E6")]
	[Address(RVA = "0x1809464", Offset = "0x1809464", VA = "0x1809464")]
	public AnimationRuntimeHandle _003C_003EiFixBaseProxy_PlayAnim(AnimationID P0, bool P1, float P2, bool P3, bool P4)
	{
		return null;
	}
}
