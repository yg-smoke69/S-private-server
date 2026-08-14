using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x20009AB")]
internal class PlayerReaper : PlayerNetwork
{
	[Token(Token = "0x400599B")]
	private const string PONEIKDLJJC = "Bip01";

	[Token(Token = "0x400599C")]
	[FieldOffset(Offset = "0x9C8")]
	private Transform PINOEIEHFAE;

	[Token(Token = "0x400599D")]
	private const int FMJKHFFHNBI = 0;

	[Token(Token = "0x400599E")]
	private const int JCDFIBEOJJA = 1;

	[Token(Token = "0x400599F")]
	private const int MIGANIBOINO = 2;

	[Token(Token = "0x40059A0")]
	private const int ANPBPKGEAEL = 3;

	[Token(Token = "0x40059A1")]
	[FieldOffset(Offset = "0x9CC")]
	private GameObject BPPKIFJHHPO;

	[Token(Token = "0x40059A2")]
	[FieldOffset(Offset = "0x9D0")]
	private bool _003CHIKALFMCLCA_003Ek__BackingField;

	[Token(Token = "0x40059A3")]
	[FieldOffset(Offset = "0x9D4")]
	private GameObject MJHCDCDLDAO;

	[Token(Token = "0x40059A4")]
	[FieldOffset(Offset = "0x9D8")]
	private Dictionary<int, int> NJLPKJLOLAM;

	[Token(Token = "0x40059A5")]
	[FieldOffset(Offset = "0x9DC")]
	private Dictionary<KeyCode, int> IJOALECLHDE;

	[Token(Token = "0x40059A6")]
	[FieldOffset(Offset = "0x0")]
	private static Action HMDOHFBHDOB;

	[Token(Token = "0x170005F2")]
	public override Collider NDIJPOAKKGG
	{
		[Token(Token = "0x6004AC6")]
		[Address(RVA = "0x2100194", Offset = "0x2100194", VA = "0x2100194", Slot = "95")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005F3")]
	private Transform EINMDDEJHPH
	{
		[Token(Token = "0x6004AD5")]
		[Address(RVA = "0x2101A58", Offset = "0x2101A58", VA = "0x2101A58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005F4")]
	private bool PPKGACCKELF
	{
		[Token(Token = "0x6004AD6")]
		[Address(RVA = "0x2101A50", Offset = "0x2101A50", VA = "0x2101A50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004AD7")]
		[Address(RVA = "0x210260C", Offset = "0x210260C", VA = "0x210260C")]
		set
		{
		}
	}

	[Token(Token = "0x6004AC5")]
	[Address(RVA = "0x20FFFAC", Offset = "0x20FFFAC", VA = "0x20FFFAC")]
	public PlayerReaper()
	{
	}

	[Token(Token = "0x6004AC7")]
	[Address(RVA = "0x2100330", Offset = "0x2100330", VA = "0x2100330", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6004AC8")]
	[Address(RVA = "0x210094C", Offset = "0x210094C", VA = "0x210094C")]
	private void GCJKDENPDMD(ushort IIJMFDCBGAJ, ushort NPLOJLCFCKO)
	{
	}

	[Token(Token = "0x6004AC9")]
	[Address(RVA = "0x2100A94", Offset = "0x2100A94", VA = "0x2100A94")]
	public uint GetSoul()
	{
		return default(uint);
	}

	[Token(Token = "0x6004ACA")]
	[Address(RVA = "0x2100BB8", Offset = "0x2100BB8", VA = "0x2100BB8")]
	public uint GetEquipSetIndex()
	{
		return default(uint);
	}

	[Token(Token = "0x6004ACB")]
	[Address(RVA = "0x2100CDC", Offset = "0x2100CDC", VA = "0x2100CDC")]
	private void NIJPOCMEMLK(bool IIJMFDCBGAJ, bool NPLOJLCFCKO)
	{
	}

	[Token(Token = "0x6004ACC")]
	[Address(RVA = "0x2100E4C", Offset = "0x2100E4C", VA = "0x2100E4C")]
	private void PMAPPLPDBJA(ushort IIJMFDCBGAJ, ushort NPLOJLCFCKO)
	{
	}

	[Token(Token = "0x6004ACD")]
	[Address(RVA = "0x2100F9C", Offset = "0x2100F9C", VA = "0x2100F9C")]
	private void MLMBDBCDAHC(bool NPEGNFDEEDB)
	{
	}

	[Token(Token = "0x6004ACE")]
	[Address(RVA = "0x210020C", Offset = "0x210020C", VA = "0x210020C")]
	public bool GetReaperState()
	{
		return default(bool);
	}

	[Token(Token = "0x6004ACF")]
	[Address(RVA = "0x2101210", Offset = "0x2101210", VA = "0x2101210")]
	public void TestSetSoulCount(ushort BLEAICPKPGL)
	{
	}

	[Token(Token = "0x6004AD0")]
	[Address(RVA = "0x2101340", Offset = "0x2101340", VA = "0x2101340", Slot = "111")]
	public override void OnTriggerEnter(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x6004AD1")]
	[Address(RVA = "0x2101440", Offset = "0x2101440", VA = "0x2101440", Slot = "112")]
	public override void OnTriggerExit(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x6004AD2")]
	[Address(RVA = "0x2101540", Offset = "0x2101540", VA = "0x2101540", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint GGIDKOBOJBB = 0u)
	{
	}

	[Token(Token = "0x6004AD3")]
	[Address(RVA = "0x2101CE0", Offset = "0x2101CE0", VA = "0x2101CE0", Slot = "108")]
	public override void Dead(int HEONOMOEOLN, IHAAMHPPLMG HLJDHPGGODB, bool KCHNLMEEHOP = false, bool EPIDFMHNHFG = false)
	{
	}

	[Token(Token = "0x6004AD4")]
	[Address(RVA = "0x2102080", Offset = "0x2102080", VA = "0x2102080")]
	private void KDHJBKJENNF(Transform FFDHFKIMFDG)
	{
	}

	[Token(Token = "0x6004AD8")]
	[Address(RVA = "0x2102614", Offset = "0x2102614", VA = "0x2102614", Slot = "288")]
	protected override void HLFCFEDOOHH(JAEAODJEENM ELFLCIGJOBB)
	{
	}

	[Token(Token = "0x6004AD9")]
	[Address(RVA = "0x2102DA0", Offset = "0x2102DA0", VA = "0x2102DA0", Slot = "289")]
	public override void RequestExitTransform()
	{
	}

	[Token(Token = "0x6004ADA")]
	[Address(RVA = "0x210300C", Offset = "0x210300C", VA = "0x210300C", Slot = "290")]
	protected override void MEJHGJPLADM()
	{
	}

	[Token(Token = "0x6004ADB")]
	[Address(RVA = "0x2102B80", Offset = "0x2102B80", VA = "0x2102B80")]
	private void OPJAOHBJPHG(bool HKCBFLNFNHG)
	{
	}

	[Token(Token = "0x6004ADC")]
	[Address(RVA = "0x2103270", Offset = "0x2103270", VA = "0x2103270", Slot = "233")]
	public override void OnActSkillFinished(KBJIDDDPPOO GEPIPPKAIBK)
	{
	}

	[Token(Token = "0x6004ADD")]
	[Address(RVA = "0x2100D9C", Offset = "0x2100D9C", VA = "0x2100D9C")]
	private ResourceID GEBBICCGGFD()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6004ADE")]
	[Address(RVA = "0x2102A04", Offset = "0x2102A04", VA = "0x2102A04")]
	private ResourceID KCFOKEBFEIN()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6004ADF")]
	[Address(RVA = "0x210343C", Offset = "0x210343C", VA = "0x210343C", Slot = "208")]
	public override bool IsIgonreWeaponFireControl()
	{
		return default(bool);
	}

	[Token(Token = "0x6004AE0")]
	[Address(RVA = "0x21034B0", Offset = "0x21034B0", VA = "0x21034B0", Slot = "209")]
	public override Dictionary<int, int> GetGameControlMappingToSkillIndexMap()
	{
		return null;
	}

	[Token(Token = "0x6004AE1")]
	[Address(RVA = "0x2103508", Offset = "0x2103508", VA = "0x2103508", Slot = "210")]
	public override Dictionary<KeyCode, int> GetKeyCodeToSkillIndexMap()
	{
		return null;
	}

	[Token(Token = "0x6004AE2")]
	[Address(RVA = "0x2103560", Offset = "0x2103560", VA = "0x2103560", Slot = "211")]
	public override bool IsOverrdieFastRunControl()
	{
		return default(bool);
	}

	[Token(Token = "0x6004AE3")]
	[Address(RVA = "0x21035C4", Offset = "0x21035C4", VA = "0x21035C4", Slot = "343")]
	public override void ShowAttMsg(string LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004AE4")]
	[Address(RVA = "0x2103644", Offset = "0x2103644", VA = "0x2103644", Slot = "212")]
	public override bool IsIgnorePlayerAudioComponent()
	{
		return default(bool);
	}

	[Token(Token = "0x6004AE5")]
	[Address(RVA = "0x21036A4", Offset = "0x21036A4", VA = "0x21036A4", Slot = "213")]
	public override bool IsIgnoreHighFalling()
	{
		return default(bool);
	}

	[Token(Token = "0x6004AE6")]
	[Address(RVA = "0x2103704", Offset = "0x2103704", VA = "0x2103704", Slot = "214")]
	public override bool IsNeedAimAssists()
	{
		return default(bool);
	}

	[Token(Token = "0x6004AE7")]
	[Address(RVA = "0x2103778", Offset = "0x2103778", VA = "0x2103778", Slot = "48")]
	public override Vector3 GetAttackableCenterWS()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6004AE8")]
	[Address(RVA = "0x21038B0", Offset = "0x21038B0", VA = "0x21038B0")]
	private static void LHEMGBGNFCH()
	{
	}

	[Token(Token = "0x6004AE9")]
	[Address(RVA = "0x2103A3C", Offset = "0x2103A3C", VA = "0x2103A3C")]
	private void OJFAAHAOOHP()
	{
	}

	[Token(Token = "0x6004AEA")]
	[Address(RVA = "0x2103A48", Offset = "0x2103A48", VA = "0x2103A48")]
	public Collider _003C_003EiFixBaseProxy_get_HeadCollider()
	{
		return null;
	}

	[Token(Token = "0x6004AEB")]
	[Address(RVA = "0x2103A50", Offset = "0x2103A50", VA = "0x2103A50")]
	public new void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6004AEC")]
	[Address(RVA = "0x2103A58", Offset = "0x2103A58", VA = "0x2103A58")]
	public void _003C_003EiFixBaseProxy_OnTriggerEnter(Collider P0)
	{
	}

	[Token(Token = "0x6004AED")]
	[Address(RVA = "0x2103A60", Offset = "0x2103A60", VA = "0x2103A60")]
	public void _003C_003EiFixBaseProxy_OnTriggerExit(Collider P0)
	{
	}

	[Token(Token = "0x6004AEE")]
	[Address(RVA = "0x2103A68", Offset = "0x2103A68", VA = "0x2103A68")]
	public new void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}

	[Token(Token = "0x6004AEF")]
	[Address(RVA = "0x2103A8C", Offset = "0x2103A8C", VA = "0x2103A8C")]
	public new void _003C_003EiFixBaseProxy_Dead(int P0, IHAAMHPPLMG P1, bool P2, bool P3)
	{
	}

	[Token(Token = "0x6004AF0")]
	[Address(RVA = "0x2103AD8", Offset = "0x2103AD8", VA = "0x2103AD8")]
	public void _003C_003EiFixBaseProxy_HLFCFEDOOHH(JAEAODJEENM P0)
	{
	}

	[Token(Token = "0x6004AF1")]
	[Address(RVA = "0x2103AE0", Offset = "0x2103AE0", VA = "0x2103AE0")]
	public void _003C_003EiFixBaseProxy_RequestExitTransform()
	{
	}

	[Token(Token = "0x6004AF2")]
	[Address(RVA = "0x2103AE8", Offset = "0x2103AE8", VA = "0x2103AE8")]
	public void _003C_003EiFixBaseProxy_MEJHGJPLADM()
	{
	}

	[Token(Token = "0x6004AF3")]
	[Address(RVA = "0x2103AF0", Offset = "0x2103AF0", VA = "0x2103AF0")]
	public void _003C_003EiFixBaseProxy_OnActSkillFinished(KBJIDDDPPOO P0)
	{
	}

	[Token(Token = "0x6004AF4")]
	[Address(RVA = "0x2103AF8", Offset = "0x2103AF8", VA = "0x2103AF8")]
	public bool _003C_003EiFixBaseProxy_IsIgonreWeaponFireControl()
	{
		return default(bool);
	}

	[Token(Token = "0x6004AF5")]
	[Address(RVA = "0x2103B00", Offset = "0x2103B00", VA = "0x2103B00")]
	public Dictionary<int, int> _003C_003EiFixBaseProxy_GetGameControlMappingToSkillIndexMap()
	{
		return null;
	}

	[Token(Token = "0x6004AF6")]
	[Address(RVA = "0x2103B08", Offset = "0x2103B08", VA = "0x2103B08")]
	public Dictionary<KeyCode, int> _003C_003EiFixBaseProxy_GetKeyCodeToSkillIndexMap()
	{
		return null;
	}

	[Token(Token = "0x6004AF7")]
	[Address(RVA = "0x2103B10", Offset = "0x2103B10", VA = "0x2103B10")]
	public bool _003C_003EiFixBaseProxy_IsOverrdieFastRunControl()
	{
		return default(bool);
	}

	[Token(Token = "0x6004AF8")]
	[Address(RVA = "0x2103B18", Offset = "0x2103B18", VA = "0x2103B18")]
	public void _003C_003EiFixBaseProxy_ShowAttMsg(string P0)
	{
	}

	[Token(Token = "0x6004AF9")]
	[Address(RVA = "0x2103B20", Offset = "0x2103B20", VA = "0x2103B20")]
	public bool _003C_003EiFixBaseProxy_IsIgnorePlayerAudioComponent()
	{
		return default(bool);
	}

	[Token(Token = "0x6004AFA")]
	[Address(RVA = "0x2103B28", Offset = "0x2103B28", VA = "0x2103B28")]
	public bool _003C_003EiFixBaseProxy_IsIgnoreHighFalling()
	{
		return default(bool);
	}

	[Token(Token = "0x6004AFB")]
	[Address(RVA = "0x2103B30", Offset = "0x2103B30", VA = "0x2103B30")]
	public bool _003C_003EiFixBaseProxy_IsNeedAimAssists()
	{
		return default(bool);
	}

	[Token(Token = "0x6004AFC")]
	[Address(RVA = "0x2103B38", Offset = "0x2103B38", VA = "0x2103B38")]
	public new Vector3 _003C_003EiFixBaseProxy_GetAttackableCenterWS()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}
}
