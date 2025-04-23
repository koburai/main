import random
import os

os.chdir('C:\\Python 2024') # set directory

# capitals is changed to slugcats. these are all from my favorite game (Rain World)!
slugcats = {
    'Artificer': 'Explosions', 'Sofanthiel': 'Egg', 'Survivor': 'Basic', 'Monk': 'Weak',
    'Hunter': 'Timed', 'Gourmand': 'Crafting', 'Spearmaster': 'Messenger', 'Slugpup': 'Small',
    'Rivulet': 'Aquatic', 'Wanderer': 'Exploration', 'Saint': 'Ascension', 'Dronemaster': 'Analysis',
    'Warbound': 'Revenge', 'Winged': 'Destiny', 'Gravel': 'Solution', 'Soporific': 'Arachnophobia',
    'Technomancer': 'Mirrors', 'Dreamer': 'Memories', 'Traveler': 'Family', 'Hurricane': 'Difficulty',
    'Impulse': 'Teleport', 'Burnout': 'Climb', 'Pearl': 'Knowledge', 'Chieftan': 'Scavenger',
    'Shrieker': 'Sound', 'Warden': 'Destruction', 'Hailstorm': 'Artic', 'Sliver': 'Silence',
    'Foreign': 'Flight', 'Setae': 'Insects', 'Spore': 'Plants', 'Forager': 'Herbivore'
}

# Create the quizzes and answer key files
for quizNum in range(25):
    quizfile = open('slugcatquiz%s.txt' % (quizNum + 1), 'w')
    answerKeyFile = open('slugcatquiz_answers%s.txt' % (quizNum + 1), 'w')

    # Write out the header for the quiz
    quizfile.write('Name:\n\nDate:\n\nPeriod:\n\n')
    quizfile.write((' ' * 20) + 'Slugcat Quiz (Form%s)' % (quizNum + 1))
    quizfile.write('\n\n')

    # Shuffle the order of the abilities (previously states)
    abilities = list(slugcats.keys())
    random.shuffle(abilities)

    # you can comment this part out if you dont wanna see the key in the console
   #if quizNum == 0:
       #print(abilities)

    # Loop through all slugcats, making a question for each
    for questionnum in range(32):
        # Get right and wrong answers
        correctanswer = slugcats[abilities[questionnum]]
        wronganswers = list(slugcats.values())  # Get all values from slugcats
        wronganswers.remove(correctanswer)  # Remove correct answer from wrong answers
        wronganswers = random.sample(wronganswers, 3)
        answeroptions = wronganswers + [correctanswer]
        random.shuffle(answeroptions)

        # Write the question and answer options to the quiz file
        quizfile.write('%s. What is the best summarization of this slugcat\'s abilities: %s?\n' % (questionnum + 1, abilities[questionnum]))
        for i in range(4):
            quizfile.write('     %s.  %s\n' % ('ABCD'[i], answeroptions[i]))
        quizfile.write('\n')

        # Write the answer key to the answer key file
        answerKeyFile.write('%s. %s\n' % (questionnum + 1, 'ABCD'[answeroptions.index(correctanswer)]))

    quizfile.close()  # Close files within the loop
    answerKeyFile.close()
print("\nFiles created!")
