var SpeakJSAdapter = {
	Speak: function(txt) {
		txt = Pointer_stringify(txt);
		if(window.SpeechSynthesisUtterance && window.speechSynthesis)
		{
			console.log("speaking '", txt, "' using webspeech API");
			var msg = new SpeechSynthesisUtterance(txt);
			window.speechSynthesis.speak(msg);
		}else {
			console.log("speaking '", txt, "' using speakjs fallback");
			speak(txt);
		}
	}
}

mergeInto(LibraryManager.library, SpeakJSAdapter);