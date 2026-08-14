using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E11")]
public class AkAudioListener : MonoBehaviour
{
	[Token(Token = "0x2003E12")]
	public class BaseListenerList
	{
		[Token(Token = "0x401A4B7")]
		[FieldOffset(Offset = "0x8")]
		private readonly List<ulong> listenerIdList;

		[Token(Token = "0x401A4B8")]
		[FieldOffset(Offset = "0xC")]
		private readonly List<AkAudioListener> listenerList;

		[Token(Token = "0x17001B7A")]
		public List<AkAudioListener> ListenerList
		{
			[Token(Token = "0x60193DC")]
			[Address(RVA = "0x35C48CC", Offset = "0x35C48CC", VA = "0x35C48CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60193DB")]
		[Address(RVA = "0x35C480C", Offset = "0x35C480C", VA = "0x35C480C")]
		public BaseListenerList()
		{
		}

		[Token(Token = "0x60193DD")]
		[Address(RVA = "0x35C48D4", Offset = "0x35C48D4", VA = "0x35C48D4", Slot = "4")]
		public virtual bool Add(AkAudioListener listener)
		{
			return default(bool);
		}

		[Token(Token = "0x60193DE")]
		[Address(RVA = "0x35C4A38", Offset = "0x35C4A38", VA = "0x35C4A38", Slot = "5")]
		public virtual bool Remove(AkAudioListener listener)
		{
			return default(bool);
		}

		[Token(Token = "0x60193DF")]
		[Address(RVA = "0x35C4B9C", Offset = "0x35C4B9C", VA = "0x35C4B9C")]
		public ulong[] GetListenerIds()
		{
			return null;
		}
	}

	[Token(Token = "0x2003E13")]
	public class DefaultListenerList : BaseListenerList
	{
		[Token(Token = "0x60193E0")]
		[Address(RVA = "0x35C4808", Offset = "0x35C4808", VA = "0x35C4808")]
		public DefaultListenerList()
		{
		}

		[Token(Token = "0x60193E1")]
		[Address(RVA = "0x35C4C14", Offset = "0x35C4C14", VA = "0x35C4C14", Slot = "4")]
		public override bool Add(AkAudioListener listener)
		{
			return default(bool);
		}

		[Token(Token = "0x60193E2")]
		[Address(RVA = "0x35C4D14", Offset = "0x35C4D14", VA = "0x35C4D14", Slot = "5")]
		public override bool Remove(AkAudioListener listener)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401A4B1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly DefaultListenerList defaultListeners;

	[Token(Token = "0x401A4B2")]
	[FieldOffset(Offset = "0x10")]
	private ulong akGameObjectID;

	[Token(Token = "0x401A4B3")]
	[FieldOffset(Offset = "0x18")]
	private List<AkGameObj> EmittersToStartListeningTo;

	[Token(Token = "0x401A4B4")]
	[FieldOffset(Offset = "0x1C")]
	private List<AkGameObj> EmittersToStopListeningTo;

	[Token(Token = "0x401A4B5")]
	[FieldOffset(Offset = "0x20")]
	public bool isDefaultListener;

	[Token(Token = "0x401A4B6")]
	[FieldOffset(Offset = "0x24")]
	public int listenerId;

	[Token(Token = "0x17001B79")]
	public static DefaultListenerList DefaultListeners
	{
		[Token(Token = "0x60193D0")]
		[Address(RVA = "0x35C3DC4", Offset = "0x35C3DC4", VA = "0x35C3DC4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60193CF")]
	[Address(RVA = "0x35C3D0C", Offset = "0x35C3D0C", VA = "0x35C3D0C")]
	public AkAudioListener()
	{
	}

	[Token(Token = "0x60193D1")]
	[Address(RVA = "0x35C3E50", Offset = "0x35C3E50", VA = "0x35C3E50")]
	public void StartListeningToEmitter(AkGameObj emitter)
	{
	}

	[Token(Token = "0x60193D2")]
	[Address(RVA = "0x35C3F00", Offset = "0x35C3F00", VA = "0x35C3F00")]
	public void StopListeningToEmitter(AkGameObj emitter)
	{
	}

	[Token(Token = "0x60193D3")]
	[Address(RVA = "0x35C3FB0", Offset = "0x35C3FB0", VA = "0x35C3FB0")]
	public void SetIsDefaultListener(bool isDefault)
	{
	}

	[Token(Token = "0x60193D4")]
	[Address(RVA = "0x35C40C0", Offset = "0x35C40C0", VA = "0x35C40C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60193D5")]
	[Address(RVA = "0x35C42AC", Offset = "0x35C42AC", VA = "0x35C42AC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60193D6")]
	[Address(RVA = "0x35C4360", Offset = "0x35C4360", VA = "0x35C4360")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60193D7")]
	[Address(RVA = "0x35C4414", Offset = "0x35C4414", VA = "0x35C4414")]
	private void Update()
	{
	}

	[Token(Token = "0x60193D8")]
	[Address(RVA = "0x35C4670", Offset = "0x35C4670", VA = "0x35C4670")]
	public ulong GetAkGameObjectID()
	{
		return default(ulong);
	}

	[Token(Token = "0x60193D9")]
	[Address(RVA = "0x35C4678", Offset = "0x35C4678", VA = "0x35C4678")]
	public void Migrate14()
	{
	}
}
