import configparser
import os

def unwrap(x):
    return x[1:-1]

def task(filename):
    parser = configparser.ConfigParser()
    parser.read('regs/{}'.format(filename))
    section = parser.sections()[0]
    print(parser[section])
    print(parser.items(section))

    if not os.path.exists('themes'):
        os.makedirs('themes')
    name = os.path.splitext(os.path.basename(filename))[0]
    with open('themes/{}.ini'.format(name), 'w') as f:
        f.writelines('[colors]\n')
        for k, v in parser.items(section):
            f.writelines('{}={}\n'.format(unwrap(k), unwrap(v)))

def main():

    filenames = os.listdir('regs')

    for filename in filenames:
        task(filename)

if __name__ == '__main__':
    main()
