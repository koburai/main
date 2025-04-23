# TEST TWO

# time
import time

# first off. dictionary makes more sense to me here so lets do that instead of a list

percs = {1:.02, 2:.035, 3:.025, 4:.03, 5:.01}

# calculate the new salad time

# go ahead and declare the variables we use later (oldSal, classifs)

def newSal(oldSal, classifs):
    # get the key from the dictionary
    increase = percs[classifs]
    # get the bonus amt
    amt = oldSal * increase
    # add bonus amt to the salary
    upSal = oldSal + amt
    return upSal

# now the function to get the classification and number and all that from the clerk. no arguments bc it's just the executable but not in the executable bc not butter. clean.

def proc():
    empNum = input("Enter employee number: ")
    time.sleep(1)
    rate = input("\nEnter performance rating (E/S/U): ")
    time.sleep(1)

    if rate.upper() == 'E' or rate.upper() == 'S':
        # checks for both that actuall give the raise. also .upper makes it uppercase bc CaSe SenSitTive oogh scary
        oldSal = float(input("\nEnter base salary: "))
        time.sleep(1)
        classifs = int(input("\nEnter classification (1-5): "))
        time.sleep(1)
        upSal = newSal(oldSal, classifs)

        # now we do an f string to make it all. not need conjugates??? or w/e that word is
        # becayse otherwise it looked like print("\nEmployee" + empNum + "\n") and thats too much
        print(f"\nEmployee: {empNum}\n")
        print(f"Current salary: ${oldSal:.2f}\n") # round 2 decimals via :.2f
        print(f"New salary: ${upSal:.2f}")
        time.sleep(3)

        # onto the not good one
    elif rate.upper() == 'U':
        print(f"\nEmployee {empNum} will be placed on probation for a year.")
        time.sleep(3)

        # and for errors
    else:
        print("\nInvalid performance rating.")

# .exe time

while True:
    # run that function
    proc()
    
    cont = input("\nWould you like to enter another employee? Enter '0' to exit: ")

    # update read
    if cont == '0':
        break
# end program
print("\nT H A N K  Y O U ! ! !")
