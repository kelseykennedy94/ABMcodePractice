import re

def countOccurrences(paragraphs):
    wordCounts = {}
    
    for paragraph in paragraphs:
        paragraph = paragraph.strip()
        paragraph = paragraph.lower()
        words = re.findall(r'\b\w+\b|\S', paragraph)
        
        for word in words:
            if word in wordCounts:
                wordCounts[word] += 1
            else:
                wordCounts[word] = 1
    
    return wordCounts

paragraphs = [
    """Christopher Edward Nolan CBE (born 30 July 1970) is a British-American filmmaker. Known for his Hollywood blockbusters with complex storytelling, Nolan is considered a leading filmmaker of the 21st century. His films have grossed $5 billion worldwide. The recipient of many accolades, he has been nominated for five Academy Awards, five BAFTA Awards and six Golden Globe Awards. In 2015, he was listed as one of the 100 most influential people in the world by Time, and in 2019, he was appointed Commander of the Order of the British Empire for his contributions to film.""",
    """Nolan developed an interest in filmmaking from a young age. After studying English literature at University College London, he made several short films before his feature film debut with Following (1998). Nolan gained international recognition with his second film, Memento (2000), for which he was nominated for the Academy Award for Best Original Screenplay. He transitioned from independent to studio filmmaking with Insomnia (2002), and found further critical and commercial success with The Dark Knight Trilogy (2005–2012), The Prestige (2006) and Inception (2010); the last of these earned Nolan two Oscar nominations—Best Picture and Best Original Screenplay. This was followed by Interstellar (2014), Dunkirk (2017) and Tenet (2020). For Dunkirk, he earned two Academy Award nominations, including his first for Best Director."""
]

wordOccurrences = countOccurrences(paragraphs)

sortedOccurrences = sorted(wordOccurrences.items(), key=lambda x: x[1], reverse=False)

for word, count in sortedOccurrences:
    print(word, ":", count)
