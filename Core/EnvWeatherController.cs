using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AA2")]
public class EnvWeatherController : MonoBehaviour
{
	[Token(Token = "0x2000AA3")]
	public delegate void OnWeatherChanged(string weatherName);

	[Token(Token = "0x2000AA4")]
	private sealed class _003CTweenWeather_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005D1F")]
		[FieldOffset(Offset = "0x8")]
		internal EnvWeatherPreset preset;

		[Token(Token = "0x4005D20")]
		[FieldOffset(Offset = "0xC")]
		internal bool _003ChasSound_003E__0;

		[Token(Token = "0x4005D21")]
		[FieldOffset(Offset = "0xD")]
		internal bool _003CsoundChanged_003E__0;

		[Token(Token = "0x4005D22")]
		[FieldOffset(Offset = "0x10")]
		internal float _003CtweenTime_003E__0;

		[Token(Token = "0x4005D23")]
		[FieldOffset(Offset = "0x14")]
		internal bool _003CfootstepsSoundUpdated_003E__0;

		[Token(Token = "0x4005D24")]
		[FieldOffset(Offset = "0x18")]
		internal float duration;

		[Token(Token = "0x4005D25")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003Cratio_003E__1;

		[Token(Token = "0x4005D26")]
		[FieldOffset(Offset = "0x20")]
		internal EnvWeatherController _0024this;

		[Token(Token = "0x4005D27")]
		[FieldOffset(Offset = "0x24")]
		internal object _0024current;

		[Token(Token = "0x4005D28")]
		[FieldOffset(Offset = "0x28")]
		internal bool _0024disposing;

		[Token(Token = "0x4005D29")]
		[FieldOffset(Offset = "0x2C")]
		internal int _0024PC;

		[Token(Token = "0x1700064A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6005195")]
			[Address(RVA = "0x320D918", Offset = "0x320D918", VA = "0x320D918", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700064B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005196")]
			[Address(RVA = "0x320D920", Offset = "0x320D920", VA = "0x320D920", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005193")]
		[Address(RVA = "0x320A258", Offset = "0x320A258", VA = "0x320A258")]
		public _003CTweenWeather_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6005194")]
		[Address(RVA = "0x320C028", Offset = "0x320C028", VA = "0x320C028", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005197")]
		[Address(RVA = "0x320D928", Offset = "0x320D928", VA = "0x320D928", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005198")]
		[Address(RVA = "0x320D93C", Offset = "0x320D93C", VA = "0x320D93C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4005D06")]
	[FieldOffset(Offset = "0x0")]
	private static EnvWeatherController _003Cinstance_003Ek__BackingField;

	[Token(Token = "0x4005D07")]
	[FieldOffset(Offset = "0xC")]
	public List<string> weatherEventNames;

	[Token(Token = "0x4005D08")]
	[FieldOffset(Offset = "0x10")]
	public List<EnvWeatherPreset> weatherPresets;

	[Token(Token = "0x4005D09")]
	[FieldOffset(Offset = "0x14")]
	public EnvWeatherPreset defaultPreset;

	[Token(Token = "0x4005D0A")]
	[FieldOffset(Offset = "0x18")]
	private EnvWeatherPreset _003CcurrentPreset_003Ek__BackingField;

	[Token(Token = "0x4005D0B")]
	[FieldOffset(Offset = "0x1C")]
	private EnvWeatherPreset _003CtargetPreset_003Ek__BackingField;

	[Token(Token = "0x4005D0D")]
	[FieldOffset(Offset = "0x24")]
	private Light mainLight;

	[Token(Token = "0x4005D0E")]
	[FieldOffset(Offset = "0x28")]
	private LensFlare lensFlare;

	[Token(Token = "0x4005D0F")]
	[FieldOffset(Offset = "0x2C")]
	private Material skyboxMaterial;

	[Token(Token = "0x4005D10")]
	[FieldOffset(Offset = "0x30")]
	private GameObject effectHolder;

	[Token(Token = "0x4005D11")]
	[FieldOffset(Offset = "0x34")]
	private Transform camTrans;

	[Token(Token = "0x4005D12")]
	[FieldOffset(Offset = "0x38")]
	private bool m_zoneInRoom;

	[Token(Token = "0x4005D13")]
	[FieldOffset(Offset = "0x39")]
	private bool m_playerInRoom;

	[Token(Token = "0x4005D14")]
	[FieldOffset(Offset = "0x3A")]
	private bool m_playerUnderShelter;

	[Token(Token = "0x4005D15")]
	[FieldOffset(Offset = "0x3C")]
	private float m_shelterCheckTime;

	[Token(Token = "0x4005D16")]
	[FieldOffset(Offset = "0x40")]
	private MADMMIICBNN m_Tmpinfo;

	[Token(Token = "0x4005D17")]
	private const float shelterCheckInterval = 0.333f;

	[Token(Token = "0x4005D18")]
	[FieldOffset(Offset = "0x44")]
	public List<ParticleSystem> particles;

	[Token(Token = "0x4005D19")]
	[FieldOffset(Offset = "0x48")]
	private List<float> particleEmissionRates;

	[Token(Token = "0x4005D1A")]
	[FieldOffset(Offset = "0x4C")]
	private AudioResource currentAudio;

	[Token(Token = "0x4005D1B")]
	[FieldOffset(Offset = "0x50")]
	private List<ResourceID> m_footStepSounds;

	[Token(Token = "0x4005D1C")]
	[FieldOffset(Offset = "0x54")]
	private Shader skyboxShader;

	[Token(Token = "0x4005D1D")]
	[FieldOffset(Offset = "0x58")]
	private Shader skyboxBlendedShader;

	[Token(Token = "0x4005D1E")]
	[FieldOffset(Offset = "0x5C")]
	private IEnumerator weatherTweener;

	[Token(Token = "0x17000646")]
	public static EnvWeatherController instance
	{
		[Token(Token = "0x600516B")]
		[Address(RVA = "0x3208368", Offset = "0x3208368", VA = "0x3208368")]
		get
		{
			return null;
		}
		[Token(Token = "0x600516C")]
		[Address(RVA = "0x32083CC", Offset = "0x32083CC", VA = "0x32083CC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000647")]
	public EnvWeatherPreset currentPreset
	{
		[Token(Token = "0x600516D")]
		[Address(RVA = "0x3208430", Offset = "0x3208430", VA = "0x3208430")]
		get
		{
			return null;
		}
		[Token(Token = "0x600516E")]
		[Address(RVA = "0x3208438", Offset = "0x3208438", VA = "0x3208438")]
		private set
		{
		}
	}

	[Token(Token = "0x17000648")]
	public EnvWeatherPreset targetPreset
	{
		[Token(Token = "0x600516F")]
		[Address(RVA = "0x3208440", Offset = "0x3208440", VA = "0x3208440")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005170")]
		[Address(RVA = "0x3208448", Offset = "0x3208448", VA = "0x3208448")]
		private set
		{
		}
	}

	[Token(Token = "0x17000649")]
	public List<ResourceID> footStepSounds
	{
		[Token(Token = "0x6005173")]
		[Address(RVA = "0x3208668", Offset = "0x3208668", VA = "0x3208668")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000002")]
	public event OnWeatherChanged onWeatherChanged
	{
		[Token(Token = "0x6005171")]
		[Address(RVA = "0x3208450", Offset = "0x3208450", VA = "0x3208450")]
		add
		{
		}
		[Token(Token = "0x6005172")]
		[Address(RVA = "0x320855C", Offset = "0x320855C", VA = "0x320855C")]
		remove
		{
		}
	}

	[Token(Token = "0x600516A")]
	[Address(RVA = "0x32081D4", Offset = "0x32081D4", VA = "0x32081D4")]
	public EnvWeatherController()
	{
	}

	[Token(Token = "0x6005174")]
	[Address(RVA = "0x3208670", Offset = "0x3208670", VA = "0x3208670")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005175")]
	[Address(RVA = "0x3208920", Offset = "0x3208920", VA = "0x3208920")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005176")]
	[Address(RVA = "0x3208924", Offset = "0x3208924", VA = "0x3208924")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6005177")]
	[Address(RVA = "0x3208F34", Offset = "0x3208F34", VA = "0x3208F34")]
	private void Start()
	{
	}

	[Token(Token = "0x6005178")]
	[Address(RVA = "0x3209050", Offset = "0x3209050", VA = "0x3209050")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005179")]
	[Address(RVA = "0x320925C", Offset = "0x320925C", VA = "0x320925C")]
	private void Update()
	{
	}

	[Token(Token = "0x600517A")]
	[Address(RVA = "0x3209CC8", Offset = "0x3209CC8", VA = "0x3209CC8")]
	private GameObject GetResourceByName(string name)
	{
		return null;
	}

	[Token(Token = "0x600517B")]
	[Address(RVA = "0x32093A0", Offset = "0x32093A0", VA = "0x32093A0")]
	private bool UnderShelterCheck(Player player, bool playerInRoom)
	{
		return default(bool);
	}

	[Token(Token = "0x600517C")]
	[Address(RVA = "0x320961C", Offset = "0x320961C", VA = "0x320961C")]
	private void UpdateEffectTransform(Transform followTrans, bool playerUnderShelter)
	{
	}

	[Token(Token = "0x600517D")]
	[Address(RVA = "0x3209B40", Offset = "0x3209B40", VA = "0x3209B40")]
	private void UpdateAudio(bool playerInRoom)
	{
	}

	[Token(Token = "0x600517E")]
	[Address(RVA = "0x320A18C", Offset = "0x320A18C", VA = "0x320A18C")]
	public void SetZoneInRoom(bool zoneInRoom)
	{
	}

	[Token(Token = "0x600517F")]
	[Address(RVA = "0x320A194", Offset = "0x320A194", VA = "0x320A194")]
	public IEnumerator TweenWeather(EnvWeatherPreset preset, float duration)
	{
		return null;
	}

	[Token(Token = "0x6005180")]
	[Address(RVA = "0x320A260", Offset = "0x320A260", VA = "0x320A260")]
	private void TriggerWeatherChangedEvent()
	{
	}

	[Token(Token = "0x6005181")]
	[Address(RVA = "0x320A7D8", Offset = "0x320A7D8", VA = "0x320A7D8")]
	public void UpdateWeatherParameters(EnvWeatherPreset preset)
	{
	}

	[Token(Token = "0x6005182")]
	[Address(RVA = "0x32089C4", Offset = "0x32089C4", VA = "0x32089C4")]
	public void SetWeather(EnvWeatherPreset preset)
	{
	}

	[Token(Token = "0x6005183")]
	[Address(RVA = "0x3209EDC", Offset = "0x3209EDC", VA = "0x3209EDC")]
	private bool PlayEnvSound(string soundLoopName, float volume)
	{
		return default(bool);
	}

	[Token(Token = "0x6005184")]
	[Address(RVA = "0x320B154", Offset = "0x320B154", VA = "0x320B154")]
	private void StopCurrentEnvSound()
	{
	}

	[Token(Token = "0x6005185")]
	[Address(RVA = "0x320AEC8", Offset = "0x320AEC8", VA = "0x320AEC8")]
	private void UpdateFootstepsSound(EnvWeatherSound soundpreset)
	{
	}

	[Token(Token = "0x6005186")]
	[Address(RVA = "0x320B274", Offset = "0x320B274", VA = "0x320B274")]
	private bool IsSkyboxTheSame(EnvSkybox lhs, EnvSkybox rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6005187")]
	[Address(RVA = "0x320B370", Offset = "0x320B370", VA = "0x320B370")]
	public EnvSkybox GetWeatherSkybox()
	{
		return null;
	}

	[Token(Token = "0x6005188")]
	[Address(RVA = "0x320B5C0", Offset = "0x320B5C0", VA = "0x320B5C0")]
	public EnvGlobalSetting GetWeatherGlobalSetting()
	{
		return null;
	}

	[Token(Token = "0x6005189")]
	[Address(RVA = "0x320B7B4", Offset = "0x320B7B4", VA = "0x320B7B4")]
	private void LerpGlobalSetting(EnvGlobalSetting previousSetting, EnvGlobalSetting targetSetting, float ratio)
	{
	}

	[Token(Token = "0x600518A")]
	[Address(RVA = "0x320AE3C", Offset = "0x320AE3C", VA = "0x320AE3C")]
	public float GetEmissionRate(ParticleSystem sys)
	{
		return default(float);
	}

	[Token(Token = "0x600518B")]
	[Address(RVA = "0x320BBBC", Offset = "0x320BBBC", VA = "0x320BBBC")]
	public void SetEmissionRate(ParticleSystem sys, float emissionRate)
	{
	}

	[Token(Token = "0x600518C")]
	[Address(RVA = "0x320BC7C", Offset = "0x320BC7C", VA = "0x320BC7C")]
	private void OnRecvWeatherChanged(object[] param)
	{
	}

	[Token(Token = "0x600518D")]
	[Address(RVA = "0x320BF04", Offset = "0x320BF04", VA = "0x320BF04")]
	public void TriggerWeatherEvent(string weatherName, float duration)
	{
	}

	[Token(Token = "0x600518E")]
	[Address(RVA = "0x320BD58", Offset = "0x320BD58", VA = "0x320BD58")]
	public void TriggerWeatherEvent(int weatherIndex, float duration)
	{
	}
}
